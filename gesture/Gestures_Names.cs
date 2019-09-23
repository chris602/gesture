using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestures
{
    public enum gestures { 
        NONE,
        A,
        B,
        LEFT_LEG_STEP_FORWARD,
        LEFT_LEG_STEP_FORWARD_RIGHT_DIAGONAL,
        LEFT_LEG_STEP_BACKWARD_RIGHT_DIAGONAL,
        LEFT_LEG_STEP_FORWARD_FIRT_POS_BACKWARD,
        RIGHT_LEG_STEP_FORWARD,
        LEFT_LEG_STEP_FORWARD_FIRST_POS_BACK,
        RIGHT_LEG_STEP_FORWARD_FIRST_POS_BACK
    };
    public class Gestures_Names
    {
        public  gestures name;

        public Gestures_Names()
        {
            name = gestures.NONE;
        }

        public gestures Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
    }
}
