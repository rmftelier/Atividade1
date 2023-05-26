using AstroAPI.Model;
using AstroAPI.Util;
using System.Collections.Concurrent;

namespace AstroAPI.Services
{
    public class HoroscopoService
    {
        public static List<string> Mensagens { get; set; } = FileUtil.ReadLines("mensagemDoDia.txt");
        public static ConcurrentDictionary<int, string> MensagensDoDia { get; set; } = new ConcurrentDictionary<int, string>();

        public static string MensagemDoDia(Usuario usuario)
        {
            var signo = (int)usuario.Signo;
            var mensagemDoDia = "";

            if (MensagensDoDia.TryGetValue(signo, out mensagemDoDia))
            {
               return mensagemDoDia;
            }

            var random = new Random();
            mensagemDoDia = Mensagens.ElementAt(random.Next(Mensagens.Count));
            MensagensDoDia.TryAdd(signo, mensagemDoDia);
            return mensagemDoDia;
        }
    }
}

