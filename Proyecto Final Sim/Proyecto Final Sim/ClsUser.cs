using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Sim
{
    class ClsUser:Conexion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int peso { get; set; }
        public int altura { get; set; }
        public int edad { get; set; }
        public string sexo { get; set; }
        public string lesiones { get; set; }
        public char Lesion_Hombro { get; set; }
        public char Lesion_Pierna { get; set; }
        public char Lesion_Espalda { get; set; }
        public char Lesion_Brazo { get; set; }
        public char Lesion_Rodilla { get; set; }
        public string enfermedades_cardiacas { get; set; }
        //ClsUser()
        //{

        //}
        public ClsUser(string Nombre, string Apellido, int peso, int altura, int edad, string sexo,
            string lesiones, string enfermedades_cardiacas, char Lesion_Hombro, char Lesion_Pierna,
            char Lesion_Espalda, char Lesion_Brazo, char Lesion_Rodilla)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.peso = peso;
            this.altura = altura;
            this.edad = edad;
            this.sexo = sexo;
            this.lesiones = lesiones;
            this.enfermedades_cardiacas = enfermedades_cardiacas;
            this.Lesion_Brazo = Lesion_Brazo;
            this.Lesion_Espalda = Lesion_Espalda;
            this.Lesion_Hombro = Lesion_Hombro;
            this.Lesion_Pierna = Lesion_Pierna;
            this.Lesion_Rodilla = Lesion_Rodilla;
        }
        public void Insertar_Usuario()
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Insert into USUARIO Values('"+Apellido+"','"+Nombre+"',"+edad+")", cn);
            cmd.ExecuteReader();
            cn.Close();
            Generar_N_User();
            Insertar_Peso_Altura();
            Insertar_Enfermedad();
            Insertar_EnfermedadCard();
            Insertar_Lesiones();
        }

        private void Insertar_Lesiones()
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Insert into LesionesUser Values(" + Id + ",'"
                + Lesion_Hombro + "','"+Lesion_Pierna+ "','" + Lesion_Espalda + "','" + Lesion_Brazo 
                + "','" + Lesion_Rodilla +"')", cn);
            cmd.ExecuteReader();
            cn.Close();
        }

        private void Insertar_EnfermedadCard()
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Insert into ECarduacaUser Values(" + Id + ",'" + enfermedades_cardiacas + "')", cn);
            cmd.ExecuteReader();
            cn.Close();
        }

        private void Insertar_Enfermedad()
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Insert into LesionesCompUser Values(" + Id + ",'" + lesiones + "')", cn);
            cmd.ExecuteReader();
            cn.Close();
        }

        private void Insertar_Peso_Altura()
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Insert into PESO_ALTURAuser Values(" + Id + "," + peso + "," + altura + ")", cn);
            cmd.ExecuteReader();
            cn.Close();
        }

        private void Generar_N_User()
        {
            Conectar();
            SqlCommand cmd = new SqlCommand("Select top 1 IDuser from USUARIO order by IDuser desc", cn);
            SqlDataReader reader= cmd.ExecuteReader();
            while (reader.Read())
            {
                Id = reader.GetInt32(0);
            }
            cn.Close();
        }
    }
}
