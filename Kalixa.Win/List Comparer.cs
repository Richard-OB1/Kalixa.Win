using System.Collections.Generic;

namespace Kalixa.Win
{
    public class ListComparer
    {
        private List<char> ListOne { get; }
        private List<char> ListTwo { get; }
        private List<char> ListCommon { get; set; }

        public ListComparer()
        {
            ListOne = new List<char>() { 'b', 'd', 'e', 'e', 'f', 'g', 'a', 'c', 'e', 'q', 'r', 'e', 'd' };
            ListTwo = new List<char>() { 'I', 'a', 'f', 'f', 'k', 'p', 'e', 'z', 'a', 't' };
            ListCommon = new List<char>();
        }

        public List<char> GetCommonList()
        {
            foreach (var listOneItem in ListOne)
            {
                foreach (var listTwoItem in ListTwo)
                {
                    if (listOneItem == listTwoItem) AddToCommonListIfNotEsists(listOneItem);
                }
            }
            return ListCommon;
        }

        public void AddToCommonListIfNotEsists(char itemToAdd)
        {
            bool existInCommonList = false;

            if (ListCommon.Count == 0)
            {
                ListCommon.Add(itemToAdd);
            }
            else
            {
                foreach (var listCommonItem in ListCommon)
                {
                    if (itemToAdd == listCommonItem) existInCommonList = true;
                }
                if (!existInCommonList) ListCommon.Add(itemToAdd);
            }
        }

    }
}