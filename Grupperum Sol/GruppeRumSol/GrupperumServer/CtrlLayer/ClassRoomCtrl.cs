﻿using GrupperumServer.DBConFold;
using GrupperumServer.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupperumServer.CtrlLayer
{
    public class ClassRoomCtrl
    {
        DBCtrl dbCtrl = new DBCtrl();
        public List<ClassRoom> GetClassRoomByAttributes(bool whiteboard, bool monitor, bool projector)
        {
            List<ClassRoom> tempclass = new List<ClassRoom>();
            tempclass = dbCtrl.GetClassRoomByAttributes(whiteboard, monitor, projector);
            return tempclass;

        }
        // constructor to make classrooms for algorithm comparing.
        public bool RequestClassRoom(int groupId, int groupSize, bool whiteboard, bool monitor, bool projector)
        {
            return dbCtrl.RequestClassRoom(groupId, groupSize, whiteboard, monitor, projector);
        }
        
    }
}
