﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Contactos.Model
{
    public class Contacto
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Organizacion { get; set; }
        public bool Favorito { get; set; }
        public ObservableCollection<Telefono> Telefonos { get; set; }

    }
    //prueba
    public class Telefono
    {
        public string Id { get; set; }
        public string Numero { get; set; }
    }
}
