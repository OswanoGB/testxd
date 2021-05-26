using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Parcial02.Context;
using Parcial02.Entities;

namespace Parcial02
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());

          /* using (var db = new ClinicucaContext())
            {
                db.questions.RemoveRange(db.questions); //limpio la tabla

                var quest = new List<Question>()
                {
                    new Question()
                    {
                        question = "¿En qué año naciste?"
                    },

                    new Question()
                    {
                    question = "¿Cómo se llamó tu primer mascota?"
                    },
                    
                    new Question()
                    {
                        question = "¿De qué colegio te graduaste de bachiller?"
                    },
                    
                    new Question()
                    {
                        question = "¿Nombre de tu película favorita?"
                    }
                    
                };
                
                quest.ForEach(q => db.Add(q));//agregando a la base de datod

                db.SaveChanges();
                

            } */ 
           
           //ya agregue las preguntas a la base de datos, por esa razon esta comentado.
           
           /* using (var db = new ClinicucaContext())
           {
               db.specialties.RemoveRange(db.specialties); //limpio la tabla

               var specialities = new List<Specialty>()
               {
                   new Specialty()
                   {
                       specialitys = "Medicina general"
                   },

                   new Specialty()
                   {
                       specialitys = "Odontología"
                   },
                   
                   new Specialty()
                   {
                       specialitys = "Psicología"
                   },
                   
                   new Specialty()
                   {
                       specialitys = "Oftalmología"
                   },
  
               };
                
               specialities.ForEach(s => db.Add(s));//agregando a la base de datod

               db.SaveChanges(); //guardo los cambios
           } */
           
           //ya agregue las especialidades a la base de datos, por esa razon esta comentado.
        }
    } 
}