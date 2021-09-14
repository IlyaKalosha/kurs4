using System;
using System.IO;
using System.Web;

namespace lab1
{
    public class IISHandler6 : IHttpHandler
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region Члены IHttpHandler

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpResponse res = context.Response;
            if (context.Request.HttpMethod == "GET")
            {
                string buffer;
                string path = "C:\\Users\\kalos\\Documents\\4kurs\\prog_v_inet\\lab\\lab1\\lab1\\templates\\2.html";
                using (StreamReader sr = new StreamReader(path))
                {
                    buffer = sr.ReadToEnd();
                }
                res.Write(buffer);
            }
            else if (context.Request.HttpMethod == "POST")
            {
                res.Write(Convert.ToInt32(context.Request.Params.Get("x")) * Convert.ToInt32(context.Request.Params.Get("y")));

            }
        }

        #endregion
    }
}
