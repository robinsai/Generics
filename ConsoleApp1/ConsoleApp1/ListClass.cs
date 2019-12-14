using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ListClass<T>
    {
        //        /     
        //array \/          /
        //remove function \/
                 //    /   
       //add function\/
       //add contains 
       //count to keep track of how many items

        T[] array = new T[0];

         
   
        public T this[int lit]
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
        public bool containsValue(T num)
        {
            bool foundIt = false;
            for(int i =0; i < array.Length;i++)
            {
                if(num.Equals(array[i]))
                {
                    foundIt = true;
                    return foundIt;
                }
            }
            return false;
        }
       
        public void removeValue(T number)
        {
            
            int indexToRemove = 0;
            bool numberFound = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (number.Equals(array[i]))
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
                T[] temp = new T[array.Length - 1];
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
        public void addValue(T value)
        {
            T[] temp = new T[array.Length + 1];
            for(int i=0; i < temp.Length;i++)
            {
                if (i == temp.Length-1)
                {
                    temp[i] = value;
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
