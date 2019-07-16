using System;
using System.Collections.Generic;
using System.Text;

namespace ZooHw
{
    interface ITransfer
    {
        void AddAnimalsToZoos(Animals pAnimal);
        void TransferAnimal(Zoo zoo, Animals pAnimal);

    }
}
 