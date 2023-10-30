using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace APIFarmaceutica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public FileController(IWebHostEnvironment env)
        {
            _env = env;
        }

        //Verbo de accion (HttPost) de tipo POST
        //Renombrar la ruta de la accion a "cargar-archivo" con el atributo "Route"
        [HttpPost, Route("cargar_archivo")]
        public Task<bool> UploadFile()
        {
            //Variable que retorna el valor del resultado del metodo
            //El valor predeterminado es Falso (false)
            bool resultado = false;

            //La variable "file" recibe el archivo en el objeto Request.Form
            //Del POST que realiza la aplicacion a este servicio.
            //Se envia un formulario completo donde uno de los valores es el archivo
            var file = Request.Form.Files[0];

            //Variable donde se coloca la ruta relativa de la carpeta de destino
            //del archivo cargado
            string NombreCarpeta = "/Imagenes/";

            //Variable donde se coloca la ruta raíz de la aplicacion
            //para esto se emplea la variable "_env" antes de declarada
            string RutaRaiz = _env.ContentRootPath;

            //Se concatena las variables "RutaRaiz" y "NombreCarpeta"
            //en una otra variable "RutaCompleta"
            string RutaCompleta = RutaRaiz + NombreCarpeta;


            //Se valida con la variable "RutaCompleta" si existe dicha carpeta            
            if (!Directory.Exists(RutaCompleta))
            {
                //En caso de no existir se crea esa carpeta
                Directory.CreateDirectory(RutaCompleta);
            }

            //Se valida si la variable "file" tiene algun archivo
            if (file.Length > 0)
            {
                //Se declara en esta variable el nombre del archivo cargado
                string NombreArchivo = file.FileName;

                //Se declara en esta variable la ruta completa con el nombre del archivo
                string RutaFullCompleta = Path.Combine(RutaCompleta, NombreArchivo);

                //Se crea una variable FileStream para carlo en la ruta definida
                using (var stream = new FileStream(RutaFullCompleta, FileMode.Create))
                {
                    file.CopyTo(stream);

                    //Como se cargo correctamente el archivo
                    //la variable "resultado" llena el valor "true"
                    resultado = true;
                }

            }

            //Se retorna la variable "resultado" como resultado de una tarea
            return Task.FromResult(resultado);
        }

        [HttpGet, Route("leer_archivo/{filename}")]
        public IActionResult GetFile(string filename)
        {
            string RutaRaiz = _env.ContentRootPath;
            string NombreCarpeta = "/Imagenes/";
            string RutaCompleta = RutaRaiz + NombreCarpeta + filename;
            Byte[] b = System.IO.File.ReadAllBytes(RutaCompleta);   // You can use your own method over here.
            return File(b, "image/png");
        }
    }
}
