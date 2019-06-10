using System;
using System.Collections.Generic;
using System.Text;
using DataModel;

namespace DataLayer
{
    public interface IPodDbManager
    {
        Pod GetPod();
        void AddPod(Pod entity);
    }
}
