using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IvanovS
{
    public class DeviceShop
    {
        private List<Smartphone> smartphones;

        public DeviceShop()
        {
            smartphones = new List<Smartphone>();
        }

        public void AddSmartphone(Smartphone smartphone)
        {
            smartphones.Add(smartphone);
        }

        public void SortSmartphone()
        {
            smartphones.Sort((x, y) =>
            {
                int modelSmartphone = x.Mark.CompareTo(y.Mark);
                if(modelSmartphone == 0)
                {
                    x.Cost.CompareTo(y.Cost);
                }
                return modelSmartphone;
            });
        }

        public void SaveToFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter (filename))
            {
                foreach (var device in smartphones)
                {
                    sw.WriteLine(device);
                }
            }
        }

    }
}
