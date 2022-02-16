using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstProject {
    class Stationary{

        private string stat_item;
        private int stat_price;

        public Stationary(){

        }
        public Stationary(string item,int price){
            this.stat_item = item;
            this.stat_price = price;
        }
        List<Stationary> item = new List<Stationary>();
        
        public void displayItems(){
            item.Add(new Stationary("Pencil",2));
            item.Add(new Stationary("Pen",20));
            item.Add(new Stationary("Eraser",5));

            foreach(Stationary st in item){
              System.Console.WriteLine("Item : "+st.stat_item +" Price : Rs."+st.stat_price);
            }

        }

        public static void main(string[] args)
      {
          Stationary c = new Stationary();
          c.displayItems();

      }
    }
}