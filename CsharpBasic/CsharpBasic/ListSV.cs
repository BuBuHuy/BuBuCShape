using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpBasic
{
    class ListSV
    {
        SV[] ls;
        int index;
        public ListSV()
        {
            this.index = 0;
            this.ls = new SV[50];

        }
        
        public void ShowListSV()
        {
            for (int i = 0; i < index; i++)
            {
                ls[i].show();
            }
        }
        public int SearchSV(string MSSV)
        {
            for (int i = 0; i < this.index; i++)
            {
                if (this.ls[i].pMSSV == MSSV) return i;
            }
            return -1;
        }
        public void AddSV(SV s)
        {
            this.ls[index] = s;
            this.index++;
        }
        public void UpdateSV(string MSSV)
        {
            int id = SearchSV(MSSV);
            if (id != -1)
            {
                Console.WriteLine("Input Student  : ");
                SV us = SV.inputSV();
                us.pMSSV = MSSV;
                ls[id] = us;
                Console.WriteLine("Update Successed !");
            }
            else Console.WriteLine("Update Failed !");
        }
        public void DeleteSV(string MSSV)
        {
            int id = SearchSV(MSSV);
            if (id != -1)
            {
                for (int i = id; i < this.index - 1; i++)
                {
                    ls[i] = ls[i + 1];
                }
                ls[index] = null;
                this.index--;
                Console.WriteLine("Delete Successed !");

            }
            else Console.WriteLine("Delete Failed !");

        }
        public static void swapS(ref SV a, ref SV b)
        {
            SV temp = new SV(b);
            b = a;
            a = temp;
        }
        public void SortSV()
        {
            for (int i = 0; i < this.index - 1; i++)
                for (int j = i + 1; j < this.index; j++)
                {
                    if (ls[i].pDTB < ls[j].pDTB) swapS(ref ls[i], ref ls[j]);
                    if (ls[i].pDTB == ls[j].pDTB)
                    {
                        if (ls[i].pDRL < ls[j].pDRL) swapS(ref ls[i], ref ls[j]);
                    }
                }
        }
        

    }
}
