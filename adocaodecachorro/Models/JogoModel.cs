using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogoDeJogos.Models
{
    public class JogoModel
    {
        public string GameID { get; set; }
        public string Genero { get; set; }
        public string Plataforma { get; set; }
        public int AnoLancamento { get; set; }
        public bool GOT { get; set; }
      
        public static List<JogoModel> CriarLista()
        {
            var lista = new List<JogoModel>();

            lista.Add(new JogoModel() { GameID = "Elder Ring", Genero = "Aventura", AnoLancamento = 2022, GOT = true});
            lista.Add(new JogoModel() { GameID = "The Last Of Us Part II", Genero = "Suspense", AnoLancamento = 2020, GOT = true});

            return lista;
        }
    }

}
