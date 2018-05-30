﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EindwerkCarParkingCore.Models
{
   public class ParkingsDTO
    {
        public int Id { get; set; }
        public string ParkingNaam { get; set; }
        public string GemeenteGemeenteNaam { get; set; }

    }

    public class ParkingsDetailDTO
    {
        public int Id { get; set; }
        public string ParkingNaam { get; set; }
        public string LocatieStraat { get; set; }
        public string LocatieNummer { get; set; }
        public string GemeenteGemeenteNaam { get; set; }
        public string LandLandNaam { get; set; }
        public string BedrijfsNaam { get; set; }
    }

    public class ParkingUsersDTO
    {
        public int Id { get; set; }
        public string EigenaarNaam { get; set; }
    }

    public class GemeenteDTO
    {
        public int Id { get; set; }
        public string GemeenteNaam { get; set; }
    }

    public class LocatieDTO
    {
        public int Id { get; set; }
        public string Straat { get; set; }
    }

    public class LandDTO
    {
        public int Id { get; set; }
        public string LandNaam { get; set; }
    }
    //public class SoortDTO
    //{
    //    public int Id { get; set; }
    //    public string SoortNaam { get; set; }
    //}

    public class ToataalDTO
    {
        public int Id { get; set; }
        public int MaxParkings { get; set; }
        public int BezetteParkings { get; set; }
    }
}