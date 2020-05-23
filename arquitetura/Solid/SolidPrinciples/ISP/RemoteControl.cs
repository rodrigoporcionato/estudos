using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrinciples.ISP
{


    //public interface IClick
    //{
    //    void onClick(Object obj);
    //    void onLongClick(Object obj);
    //    void onTouch(Object obj);
    //}

    public interface IClick
    {
        void onClick(Object obj);
        void onLongClick(Object obj);
    }

    public interface ITouch
    {
        void onClick(Object obj);
        void onTouch(Object obj);
    }

    class RemoteControl
    {
    }
}
