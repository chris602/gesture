using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Kinect;

namespace Gestures
{
    class Program
    {
        static Gestures_Names g = new Gestures_Names();

      //  static Left_Hand_UP_and_Down gesture_Left_Hand_UP_and_Down = new Left_Hand_UP_and_Down();
      //  static Left_Hand_Place_To_Middle gesture_Left_Hand_Place_To_Middle = new Left_Hand_Place_To_Middle();
        static Left_Leg_Step_Forward gesture_left_leg_step_forward = new Left_Leg_Step_Forward();
        static Left_Leg_Step_Forward_Right_Diagonal gesture_left_leg_step_forward_right_diagonal = new Left_Leg_Step_Forward_Right_Diagonal();
        static Right_Leg_Step_Forward gesture_right_leg_step_forward = new Right_Leg_Step_Forward();
        static Left_Leg_Step_Forward_First_Pos_Backward gesture_left_leg_step_forward_first_pos_backward = new Left_Leg_Step_Forward_First_Pos_Backward();
        static Right_Leg_Step_Forward_First_Pos_Backward gesture_right_leg_step_forward_first_pos_backward = new Right_Leg_Step_Forward_First_Pos_Backward();
        static void Main(string[] args)
        {
            var sensor = KinectSensor.KinectSensors.Where(s => s.Status == KinectStatus.Connected).FirstOrDefault();
            if (sensor != null)
            {
                sensor.SkeletonStream.Enable();
                sensor.SkeletonFrameReady += SensorSkeletonFrameReady;

              //  gesture_Left_Hand_UP_and_Down.recognized += Gesture_GestureRecognized;
              //  gesture_Left_Hand_Place_To_Middle.recognizedB += Gesture_GestureRecognizedB;
                gesture_left_leg_step_forward.recognized_Left_Leg_Step_Forward += Gestue_GestureRecognized_Left_Leg_Step_Forward;
                gesture_left_leg_step_forward_right_diagonal.recognized_Left_Leg_Step_Forward_Right_Diagonal += Gestue_GestureRecognized_Left_Leg_Step_Forward_Right_Diagonal;
                gesture_right_leg_step_forward.recognized_Right_Leg_Step_Forward += Gestue_GestureRecognized_Right_Leg_Step_Forward;
                gesture_left_leg_step_forward_first_pos_backward.recognized_Left_Leg_Step_Forward_First_Pos_Backward += Gestue_GestureLeft_Leg_Step_Forward_First_Pos_Backward;
                gesture_right_leg_step_forward_first_pos_backward.recognized_Right_Leg_Step_Forward_First_Pos_Backward += Gestue_GestureRight_Leg_Step_Forward_First_Pos_Backward;

                sensor.Start();
            }

            Console.ReadKey();
        }

        static void SensorSkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    Skeleton[] skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];

                    skeletonFrame.CopySkeletonDataTo(skeletons);

                    if (skeletons.Length > 0)
                    {
                        var user = skeletons.Where(u => u.TrackingState == SkeletonTrackingState.Tracked).FirstOrDefault();

                       // Console.Write(g);

                        if (user != null)
                        {                           
                           // gesture_Left_Hand_UP_and_Down.Update(user, g);
                           // gesture_Left_Hand_Place_To_Middle.Update(user, g);
                            gesture_left_leg_step_forward.Update(user, g);
                            gesture_left_leg_step_forward_right_diagonal.Update(user, g);
                            gesture_right_leg_step_forward.Update(user, g);
                            gesture_left_leg_step_forward_first_pos_backward.Update(user, g);
                            gesture_right_leg_step_forward_first_pos_backward.Update(user, g);
                        }
                    }
                }
            }
        }

        static void Gesture_GestureRecognized(object sender, EventArgs e)
        {
            Console.Write(g.Name + "111111111111\n");
        }

        static void Gesture_GestureRecognizedB(object sender, EventArgs e)
        {
            Console.Write(g.Name + "222222222222222222\n");
        }

        static void Gestue_GestureRecognized_Left_Leg_Step_Forward(object sender, EventArgs e)
        {
            Console.Write(g.Name + "\n");
        }

        static void Gestue_GestureRecognized_Left_Leg_Step_Forward_Right_Diagonal(object sender, EventArgs e)
        {
            Console.Write(g.Name + "\n");
        }

        static void Gestue_GestureRecognized_Right_Leg_Step_Forward(object sender, EventArgs e)
        {
            Console.Write(g.Name + "\n");
        }

        static void Gestue_GestureLeft_Leg_Step_Forward_First_Pos_Backward(object sender, EventArgs e)
        {
            Console.Write(g.Name + "\n");
        }

        static void Gestue_GestureRight_Leg_Step_Forward_First_Pos_Backward(object sender, EventArgs e)
        {
            Console.Write(g.Name + "\n");
        }
    }
}
