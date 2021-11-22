using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades; 

namespace Formulario
{
    public static class ClaseExtensora
    {
        public static void MostrarMensajeError(this Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Error : {ex.Message}");
            sb.AppendLine(ex.StackTrace);
            MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            try
            {
                Task tsk = new Task(() => ClaseExtensora.GuardarLogErrores(ex));
                tsk.Start();
            }
            catch (Exception exArchivoLog)
            {
                MessageBox.Show(exArchivoLog.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private static void GuardarLogErrores(Exception ex)
        {
            string ruta = Archivo.GenerarRuta("Errores.txt");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Fecha y hora del error:");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine("Descripcion:");
            sb.AppendLine(ex.Message);
            sb.AppendLine(ex.StackTrace);
            sb.AppendLine("---------------------------------------------------------------------------------------------------------");
            Archivo.EscribirAgregarTxt(ruta, sb.ToString());
        }

    }
}
