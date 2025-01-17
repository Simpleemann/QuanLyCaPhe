﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF.DTO
{
    public class Food
    {
        public Food(int id, string name, int idCategory, float price)
        {
            this.ID = id;
            this.Name = name;
            this.IDCategory = idCategory;
            this.Price = price;
        }

        public Food(DataRow row)
        {
            this.ID = (int)row["id"];
            this.Name = row["name"].ToString();
            this.IDCategory = (int)row["idCategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }
        private float price;
        private int iDCategory;
        private string name;
        private int iD;
        
        public int ID
        {
            get => iD;
            set => iD = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public int IDCategory
        {
            get => iDCategory;
            set => iDCategory = value;
        }
        public float Price
        {
            get => price;
            set => price = value;
        }
    }
}
