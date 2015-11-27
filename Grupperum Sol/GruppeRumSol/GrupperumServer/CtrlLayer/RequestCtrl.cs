﻿using GrupperumServer.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupperumServer.CtrlLayer
{
    // requestCtrl sammenligner lister af objekterne RequestClassroom og ClassRoom. (De dannes i 
    // modellaget og som lister på DBCtrl ved navn stillNotFulfilled og LessThanThree)
    class RequestCtrl    
    {
        public RequestCtrl()
        {
            RequestClassroom requestClassroom;
            List<RequestClassroom> stillNotFulfilled = new List<RequestClassroom>();
            ClassRoom classRoom;
            List<ClassRoom> lessThanThree = new List<ClassRoom>();
        }
        public void doTheFunkyAlgorythm(RequestClassroom requestClassroom, List<RequestClassroom> stillNotFulfilled, List<ClassRoom> lessThanThree)
        {
            foreach (RequestClassroom rc in stillNotFulfilled)
            {
                if (rc.RequestCode == 7)
                {
                    foreach(ClassRoom c in lessThanThree)  
                    {
                        if(c.RequestMatch == 7)
                        {
                            rc.ClassroomName = c.Name;
                            stillNotFulfilled.Remove(rc);
                            c.SpaceLeft -= rc.GroupSize;
                            c.RequestMatch -= rc.RequestCode;
                            c.GroupCount++;
                        }
                    }          
                }
            }

        }

    }
}
