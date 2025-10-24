using ChatBot.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace BotChat.Servicios
{
    public class BotChatService
    {
        public static BotChatResponse Predict(string botName, string input)
        {
            string respuesta = string.Empty;
            string accion = string.Empty;
            string funcion = string.Empty;
            string param = string.Empty;

            if (input == "")
            {
                respuesta = "el input esta vacio";
                accion = "";
                param = "";
                funcion = "";
            }
            else
            {
                string directorioEjecutable = AppDomain.CurrentDomain.BaseDirectory;
                string rutaArchivoJson = Path.Combine(directorioEjecutable, @"TrainData", botName + ".json");
                string json = File.ReadAllText(rutaArchivoJson);

                List<BotChatResponse> responses = JsonSerializer.Deserialize<List<BotChatResponse>>(json);

                string[] tokens = Regex.Split(input, @"\W+");
                Dictionary<BotChatResponse, int> puntajes = new Dictionary<BotChatResponse, int>();

                foreach (var response in responses)
                {
                    int puntaje = 0;
                    foreach (var palabrasClave in response.PalabrasClave)
                    {
                        if (tokens.Any(t => String.Equals(t, palabrasClave, StringComparison.OrdinalIgnoreCase)))
                        {
                            puntaje++;
                        }
                        puntajes[response] = puntaje;
                    }
                    var respuestasOrdenadas = puntajes.OrderByDescending(y => y.Value);
                    var respuestaFinal = (respuesta: "no se puede procesar la solicitud.", pregunta: "", catalogo: "", param: "");

                    if (respuestasOrdenadas.Any() && respuestasOrdenadas.First().Value > 0)
                    {
                        respuestaFinal = (
                            respuesta: respuestasOrdenadas.First().Key.Respuesta,
                            accion: respuestasOrdenadas.First().Key.Accion,
                            funcion: respuestasOrdenadas.First().Key.Funcion,
                            param: respuestasOrdenadas.First().Key.Param
                            );
                    }
                    respuesta = respuestaFinal.respuesta;
                    accion = respuestaFinal.pregunta;
                    param = respuestaFinal.param;
                    funcion = respuestaFinal.catalogo;
                }

                return new BotChatResponse
                {
                    Respuesta = respuesta,
                    Accion = accion,
                    Param = param,
                    Funcion = funcion,
                };
            }
            BotChatResponse botChatResponse = new BotChatResponse();
            return botChatResponse;
        }
    }
}
