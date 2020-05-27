using Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IDeckRepository
    {
        void ResetDesk();

        Card GetCard();
    }
}
