using Nota1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowaNota.Util
{
    class PastaJsonConverter
    {
        public PastaJsonConverter()
        {

        }

        public static String pastaConverter(List<Pasta> pastas)
        {
            string json = null;

            if(pastas == null)
            {
                return null;
            }
            foreach(Pasta p in pastas)
            {
                json += String.Concat
                    ("{ 'id': ",p.id.ToString(),
                    ",'parent':",p.pastaPai == null? "'#'" : p.pastaPai.ToString(),
                    ",'text':'",p.nome,"',",
                    "'icon':'glyphicon glyphicon-folder-open'},");
            }
            return json;
        }
    }
}
