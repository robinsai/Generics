using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ListClass
    {
        //        /     
        //array \/          /
        //remove function \/
                 //    /   
       //add function\/
       //add contains 
       //count to keep track of how many items

        int[] array = new int[0];

         
   
        public int this[int lit]
        {
            get
            {
                return array[lit];
            }
        }
            

        public int amountOfItems => array.Length;
 
        public ListClass()

        {
        }
        public bool containsValue(int num)
        {
            bool foundIt = false;
            for(int i =0; i < array.Length;i++)
            {
                if(num == array[i])
                {
                    foundIt = true;
                    return foundIt;
                }
            }
            return false;
        }
       
        public void removeValue(int number)
        {
            
            int indexToRemove = 0;
            bool numberFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    indexToRemove = i;
                    numberFound = true;
                }
            }
            if (numberFound == false)
            {
               throw new Exception("Number doesnt exist in the list.");
            }
            else
            {
                int[] temp = new int[array.Length - 1];
                int count = 0;
                for(int i =0; i < array.Length;i++)
                {
                    if(i != indexToRemove)
                    {
                        temp[count] = array[i];
                        count++;
                    }
                } 
                array = temp;
            }
          
        }
        public void addValue(int num)
        {
            int[] temp = new int[array.Length + 1];
            for(int i=0; i < temp.Length;i++)
            {
                if (i == temp.Length-1)
                {
                    temp[i] = num;
                }
                else
                {
                    temp[i] = array[i];
                }
            }
            array = temp;
        }
    }
}
