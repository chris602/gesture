using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Kinect;

namespace Gestures
{
    public interface General_Gesture_Segment
    {
        int Update(Skeleton skeleton);
    }

    public class Left_Hand_Place : General_Gesture_Segment
    {
        public int Update(Skeleton skeleton)
        {
            Joint shoulder_left = skeleton.Joints[JointType.ShoulderLeft];
            Joint elbow_left = skeleton.Joints[JointType.ElbowLeft];
            Joint wrist_left = skeleton.Joints[JointType.WristLeft];
            Joint hand_left = skeleton.Joints[JointType.HandLeft];

            if (shoulder_left.Position.Y > elbow_left.Position.Y &&
                elbow_left.Position.Y > wrist_left.Position.Y &&
                elbow_left.Position.X <= shoulder_left.Position.X + 0.08 &&
                elbow_left.Position.X >= shoulder_left.Position.X - 0.08 &&
                wrist_left.Position.X <= elbow_left.Position.X + 0.08 &&
                wrist_left.Position.X >= elbow_left.Position.X - 0.08 /*&&
                wrist_left.Position.Z <= elbow_left.Position.Z + 0.08 &&
                wrist_left.Position.Z >= elbow_left.Position.Z - 0.08*/)
            {
                //Console.Write(shoulder_left.Position.Y - elbow_left.Position.Y + "\n");
            /*    double v1x = shoulder_left.Position.X - elbow_left.Position.X;
                double v1y = shoulder_left.Position.Y - elbow_left.Position.Y;
                double v1z = shoulder_left.Position.Z - elbow_left.Position.Z;

                double v2x = wrist_left.Position.X - elbow_left.Position.X;
                double v2y = wrist_left.Position.Y - elbow_left.Position.Y;
                double v2z = wrist_left.Position.Z - elbow_left.Position.Z;

                double angle = angle_computation(v1x, v1y, v1z, v2x, v2y, v2z);

                double v3x = elbow_left.Position.X - wrist_left.Position.X;
                double v3y = elbow_left.Position.Y - wrist_left.Position.Y;
                double v3z = elbow_left.Position.Z - wrist_left.Position.Z;

                double v4x = hand_left.Position.X - wrist_left.Position.X;
                double v4y = hand_left.Position.Y - wrist_left.Position.Y;
                double v4z = hand_left.Position.Z - wrist_left.Position.Z;

                double angle1 = angle_computation(v3x, v3y, v3z, v4x, v4y, v4z);*/
                //Console.Write("Angle: " + angle1 + "\n");
                //Console.Write("ZZZZZZZZZZZZZZZZZZZz\n");
              /*  if (angle <= 180 && angle > 160 && angle1 <= 180 && angle1 > 160)
                {
                    //Console.Write("QQQQQQQQQQQQQQQQQQQQQQQQ\n");
                    if (Math.Abs(shoulder_left.Position.Z - elbow_left.Position.Z) <= 0.10 &&
                        Math.Abs(shoulder_left.Position.Z - elbow_left.Position.Z) >= 0)
                    {
                        return 0;
                    }
                }*/
                return 0;
            }
            return 1;
        }
    }

    public class Left_Hand_Up : General_Gesture_Segment
    {
        public int Update(Skeleton skeleton)
        {
            Joint shoulder_left = skeleton.Joints[JointType.ShoulderLeft];
            Joint elbow_left = skeleton.Joints[JointType.ElbowLeft];
            Joint wrist_left = skeleton.Joints[JointType.WristLeft];
            Joint hand_left = skeleton.Joints[JointType.HandLeft];

            //Console.Write("ANTE GEIA\n");

            if (shoulder_left.Position.Y < elbow_left.Position.Y &&
                elbow_left.Position.Y < wrist_left.Position.Y &&
                elbow_left.Position.X <= shoulder_left.Position.X + 0.1 &&
                elbow_left.Position.X >= shoulder_left.Position.X - 0.1 &&
                wrist_left.Position.X <= elbow_left.Position.X + 0.1 &&
                wrist_left.Position.X >= elbow_left.Position.X - 0.1)
            {
                //Console.Write(shoulder_left.Position.Y - elbow_left.Position.Y + "\n");
             /*   double v1x = shoulder_left.Position.X - elbow_left.Position.X;
                double v1y = shoulder_left.Position.Y - elbow_left.Position.Y;
                double v1z = shoulder_left.Position.Z - elbow_left.Position.Z;

                double v2x = wrist_left.Position.X - elbow_left.Position.X;
                double v2y = wrist_left.Position.Y - elbow_left.Position.Y;
                double v2z = wrist_left.Position.Z - elbow_left.Position.Z;

                double angle = angle_computation(v1x, v1y, v1z, v2x, v2y, v2z);

                double v3x = elbow_left.Position.X - wrist_left.Position.X;
                double v3y = elbow_left.Position.Y - wrist_left.Position.Y;
                double v3z = elbow_left.Position.Z - wrist_left.Position.Z;

                double v4x = hand_left.Position.X - wrist_left.Position.X;
                double v4y = hand_left.Position.Y - wrist_left.Position.Y;
                double v4z = hand_left.Position.Z - wrist_left.Position.Z;

                double angle1 = angle_computation(v3x, v3y, v3z, v4x, v4y, v4z);*/
                //Console.Write("Angle: " + angle + "\n");
                //Console.Write("ZZZZZZZZZZZZZZZZZZZz\n");
               /* if (angle <= 180 && angle > 160 && angle1 <= 180 && angle1 > 160)
                {
                    //Console.Write("QQQQQQQQQQQQQQQQQQQQQQQQ\n");
                    if (Math.Abs(shoulder_left.Position.Z - elbow_left.Position.Z) <= 0.02 &&
                        Math.Abs(shoulder_left.Position.Z - elbow_left.Position.Z) >= 0)
                    {
                        return 0;
                    }
                }*/
                //Console.Write("Ante gamisou\n");
                return 0;
            }
            //Console.Write("Ante gamisou:)\n");
            return 1;
        }
    }

    public class Left_Hand_Middle : General_Gesture_Segment
    {
        public int Update(Skeleton skeleton)
        {
            Joint shoulder_left = skeleton.Joints[JointType.ShoulderLeft];
            Joint elbow_left = skeleton.Joints[JointType.ElbowLeft];
            Joint wrist_left = skeleton.Joints[JointType.WristLeft];
            Joint hand_left = skeleton.Joints[JointType.HandLeft];

            if (shoulder_left.Position.Z > elbow_left.Position.Z &&
                elbow_left.Position.Z > wrist_left.Position.Z &&
                wrist_left.Position.Z > hand_left.Position.Z &&
                elbow_left.Position.X <= shoulder_left.Position.X + 0.08 &&
                elbow_left.Position.X >= shoulder_left.Position.X - 0.08 &&
                wrist_left.Position.X <= elbow_left.Position.X + 0.04 &&
                wrist_left.Position.X >= elbow_left.Position.X - 0.04 &&
                elbow_left.Position.Y <= shoulder_left.Position.Y + 0.08 &&
                elbow_left.Position.Y >= shoulder_left.Position.Y - 0.08)
            {
               /* double v1x = shoulder_left.Position.X - elbow_left.Position.X;
                double v1y = shoulder_left.Position.Y - elbow_left.Position.Y;
                double v1z = shoulder_left.Position.Z - elbow_left.Position.Z;

                double v2x = wrist_left.Position.X - elbow_left.Position.X;
                double v2y = wrist_left.Position.Y - elbow_left.Position.Y;
                double v2z = wrist_left.Position.Z - elbow_left.Position.Z;

                double angle = angle_computation(v1x, v1y, v1z, v2x, v2y, v2z);

                double v3x = elbow_left.Position.X - wrist_left.Position.X;
                double v3y = elbow_left.Position.Y - wrist_left.Position.Y;
                double v3z = elbow_left.Position.Z - wrist_left.Position.Z;

                double v4x = hand_left.Position.X - wrist_left.Position.X;
                double v4y = hand_left.Position.Y - wrist_left.Position.Y;
                double v4z = hand_left.Position.Z - wrist_left.Position.Z;

                double angle1 = angle_computation(v3x, v3y, v3z, v4x, v4y, v4z);
                //Console.Write("angle: " + angle + "\n");
                //Console.Write("QQQQQQQQQQQQQQQQQQQQQQQQ\n");
                if (angle <= 180 && angle > 140 && angle1 <= 180 && angle1 > 160)
                {
                    // Console.Write("QQQQQQQQQQQQQQQQQQQQQQQQ\n");
                    if (elbow_left.Position.Y - shoulder_left.Position.Y <= 0.05 &&
                        elbow_left.Position.Y - shoulder_left.Position.Y >= -0.05)
                    {*/
                        return 0;
                    //}
               // }
            }
            return 1;
        }
    }

    /*************************************LEFT HAND************************************************/

    /**********************************************************************************************/

    /*************************************RIGHT HAND***********************************************/

    /**********************************************************************************************/

    /*************************************LEFT LEG*************************************************/


    public class Left_Leg_Place_Low_Right_too : General_Gesture_Segment //kai ta 2 podia katw to ena dipla sto allo
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left  = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];
            Joint foot_right = skeleton.Joints[JointType.FootRight];
            Joint foot_left = skeleton.Joints[JointType.FootLeft];

          //  Console.Write("XXXXXXXXXXXX\n");
           // if (ankle_left.Position.Z > ankle_right.Position.Z)
          //  {
                Console.Write("ankle_left.Z: " + ankle_left.Position.Z + "\n" + "ankle_right.Z: " + ankle_right.Position.Z + "\n");
          //  }
            if(Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >=0.01 &&
               Math.Abs(ankle_left.Position.X - ankle_left.Position.X) <= 0.3 &&
               Math.Abs(ankle_left.Position.Z - ankle_left.Position.Z) <= 0.05)
                //Tentomeno podi?????????????????????????
            {
              //  Console.Write("WWWWWW\n");
                return 0;
            }

            return 1;
        }
    }

    public class Left_Leg_Low : General_Gesture_Segment //aristero podi ston aera
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            Console.Write("ankle_left.Y: " + ankle_left.Position.Y + "\n" + "ankle_right.Y: " + ankle_right.Position.Y + "\n");
            if (ankle_left.Position.Y > ankle_right.Position.Y + 0.01 &&
                ankle_left.Position.Z < ankle_right.Position.Z)//????????????
            {
               // Console.Write("fffffffffffff\n");
                return 0;
            }

            return 1;
        }
    }

    public class Left_Leg_Forward_Down : General_Gesture_Segment //aristero podi katw mprosta apo to deksi
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

           // Console.Write("ankle_left.X: " + ankle_left.Position.X + "\n" + "ankle_right.X: " + ankle_right.Position.X + "\n");

            if (Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                ankle_left.Position.X <= ankle_right.Position.X - 0.01 &&
                ankle_left.Position.Z < ankle_right.Position.Z)//?????????????/
            {
                //Console.Write("ssssssssssss\n");
                return 0;
            }

            return 1;
        }
    }

    public class Left_Leg_Left_Side_next_to_right : General_Gesture_Segment //aristero podi dipla (aristera) apo to deksi
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                Math.Abs(ankle_left.Position.X - ankle_left.Position.X) <= 0.4 &&
                Math.Abs(ankle_left.Position.Z - ankle_left.Position.Z) <= 0.05)//?????????????/
            {
                return 0;
            }

            return 1;
        }
    }

    public class Left_Leg_Backward_Down : General_Gesture_Segment //aristero podi katw pisw apo to deksi
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                ankle_left.Position.X > ankle_right.Position.X  &&
                ankle_left.Position.Z > ankle_right.Position.Z)//?????????????/
            {
                return 0;
            }

            return 1;
        }
    }

    public class Left_Leg_Right_Forward_Diagonal : General_Gesture_Segment //aristero podi diagwnia mprosta tou deksiou
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (ankle_left.Position.X > ankle_right.Position.X &&
                Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                ankle_left.Position.Z < ankle_right.Position.Z)//?????????????/
            {
                return 0;
            }

            return 1;
        }
    }

    public class Left_Leg_Right_Backward_Diagonal : General_Gesture_Segment //aristero podi diagwnia pisw tou deksiou
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (ankle_left.Position.X > ankle_right.Position.X &&
                Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                ankle_left.Position.Z > ankle_right.Position.Z)//?????????????/
            {
                return 0;
            }

            return 1;
        }
    }

    public class Left_Leg_Left_Forward_Diagonal : General_Gesture_Segment //aristero podi diagwnia aristera mprosta
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (ankle_left.Position.X < ankle_right.Position.X + 0.05 &&
                Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                ankle_left.Position.Z < ankle_right.Position.Z )//?????????????/
            {
                return 0;
            }

            return 1;
        }
    }

    public class Left_Leg_Left_Backward_Diagonal : General_Gesture_Segment //aristero podi diagwnia aristera pisw
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (ankle_left.Position.X < ankle_right.Position.X + 0.05 &&
                Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                ankle_left.Position.Z > ankle_right.Position.Z)//?????????????/
            {
                return 0;
            }

            return 1;
        }
    }

    /**********************************************************************************************/


    /*************************************RIGHT LEG*************************************************/


    public class Right_Leg_Place_Low_Left_too : General_Gesture_Segment //kai ta 2 podia katw to ena dipla sto allo
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint foot_left = skeleton.Joints[JointType.FootLeft];
            Joint foot_right = skeleton.Joints[JointType.FootRight];

            if (Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
               Math.Abs(ankle_left.Position.X - ankle_left.Position.X) <= 0.3 &&
               Math.Abs(ankle_left.Position.Z - ankle_left.Position.Z) <= 0.05)
            //Tentomeno podi?????????????????????????
            {
                return 0;
            }

            return 1;
        }
    }

    public class Right_Leg_Low : General_Gesture_Segment //deksi podi ston aera
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (ankle_right.Position.Y > ankle_left.Position.Y + 0.01 &&
                ankle_left.Position.Z < ankle_right.Position.Z)
            //????????????
            {
                return 0;
            }

            return 1;
        }
    }

    public class Right_Leg_Forward_Down : General_Gesture_Segment //deksi podi katw mprosta apo to aristero
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                ankle_left.Position.X <= ankle_right.Position.X - 0.01 &&
                ankle_right.Position.Z > ankle_left.Position.Z)
            {
                return 0;
            }

            return 1;
        }
    }

    public class Right_Leg_Left_Side_next_to_left : General_Gesture_Segment //deksi podi dipla (deksia) apo to aristero
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                Math.Abs(ankle_left.Position.X - ankle_left.Position.X) <= 0.4 &&
                Math.Abs(ankle_left.Position.Z - ankle_left.Position.Z) <= 0.05)//?????????????/
            {
                return 0;
            }

            return 1;
        }
    }

    public class Right_Leg_Backward_Down : General_Gesture_Segment //deksi podi katw pisw apo to aritero
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                ankle_left.Position.X > ankle_right.Position.X &&
                ankle_left.Position.Z < ankle_right.Position.Z)//?????????????/
            {
                return 0;
            }

            return 1;
        }
    }

    public class Right_Leg_Left_Forward_Diagonal : General_Gesture_Segment //deksi podi diagwnia mprosta tou aristerou
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (ankle_right.Position.X < ankle_left.Position.X && //THELOUME ELEGXO GIA FOOT?
                 Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                ankle_right.Position.Z < ankle_left.Position.Z)//?????????????/
            {
                return 0;
            }

            return 1;
        }
    }

    public class Right_Leg_Left_Backward_Diagonal : General_Gesture_Segment //deksi podi diagwnia pisw tou aristerou
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (ankle_left.Position.X < ankle_right.Position.X &&
                Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                ankle_left.Position.Z > ankle_right.Position.Z)//?????????????/
            {
                return 0;
            }

            return 1;
        }
    }

    public class Right_Leg_Right_Forward_Diagonal : General_Gesture_Segment //deksi podi diagwnia deksia mprosta
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (ankle_left.Position.X < ankle_right.Position.X + 0.05 &&
                Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                ankle_left.Position.Z > ankle_right.Position.Z)//?????????????/
            {
                return 0;
            }

            return 1;
        }
    }

    public class Right_Leg_Right_Backward_Diagonal : General_Gesture_Segment //deksi podi diagwnia deksia pisw
    {
        public int Update(Skeleton skeleton)
        {
            Joint ankle_left = skeleton.Joints[JointType.AnkleLeft];
            Joint ankle_right = skeleton.Joints[JointType.AnkleRight];

            if (ankle_left.Position.X < ankle_right.Position.X + 0.05 &&
                Math.Abs(ankle_left.Position.Y - ankle_right.Position.Y) >= 0.01 &&
                ankle_left.Position.Z > ankle_right.Position.Z)//?????????????/
            {
                return 0;
            }

            return 1;
        }
    }

    /**********************************************************************************************/
}
