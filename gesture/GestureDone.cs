using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Kinect;

namespace Gestures
{
     public class Left_Hand_UP_and_Down
    {

        readonly int num_of_frames = 1000;
        General_Gesture_Segment[] segments;

        int current_segment = 0;
        int frame_count = 0;

        public event EventHandler recognized;

        public Left_Hand_UP_and_Down()
        {
            Left_Hand_Place left_hand_place = new Left_Hand_Place();
            Left_Hand_Up left_hand_up = new Left_Hand_Up();
            Left_Hand_Middle left_hand_middle = new Left_Hand_Middle();

            segments = new General_Gesture_Segment[]
            {
                /*left_hand_place,*/
                /*left_hand_place,
                left_hand_middle,*/
                left_hand_up
            };
        }

        public void Update(Skeleton skeleton, Gestures_Names g)
        {
            int result = segments[current_segment].Update(skeleton);
           // Console.Write(g.Name);
            //g.Name = gestures.A;
            //Console.Write("current segment" + current_segment + "\n");
           // Console.Write("result" + result + "\n");
            if (result == 0)
            {
                if (current_segment + 1 < segments.Length)
                {
                    current_segment++;
                    frame_count = 0;
                }
                else
                {
                    if (recognized != null)
                    {
                        if (g.Name != gestures.A)
                        {
                            g.Name = gestures.A;
                            recognized(this, new EventArgs());
                            restart();
                        }
                    }
                }
            }
            else if (result == 1 || frame_count == num_of_frames)
            {
                restart();
            }
            else
            {
                frame_count++;
            }
        }
        public void restart()
        {
            current_segment = 0;
            frame_count = 0;
        } 
    }

     public class Left_Hand_Place_To_Middle
     {
         readonly int num_of_frames = 1000;
         General_Gesture_Segment[] segments;

         int current_segment = 0;
         int frame_count = 0;

         public event EventHandler recognizedB;

         public Left_Hand_Place_To_Middle()
         {
             Left_Hand_Place left_hand_place = new Left_Hand_Place();
             Left_Hand_Middle left_hand_middle = new Left_Hand_Middle();

            segments = new General_Gesture_Segment[]
            {
                /*left_hand_place,*/
                left_hand_place,
                left_hand_middle
            };
         }

         public void Update(Skeleton skeleton, Gestures_Names g)
         {
             int result = segments[current_segment].Update(skeleton);
             // Console.Write(g.Name);
             //g.Name = gestures.A;
             //Console.Write("current segment" + current_segment + "\n");
             // Console.Write("result" + result + "\n");
             if (result == 0)
             {
                 if (current_segment + 1 < segments.Length)
                 {
                     current_segment++;
                     frame_count = 0;
                 }
                 else
                 {
                     if (recognizedB != null)
                     {
                         if (g.Name != gestures.B)
                         {
                             g.Name = gestures.B;
                             recognizedB(this, new EventArgs());
                             restart();
                         }
                     }
                 }
             }
             else if (result == 1 || frame_count == num_of_frames)
             {
                 restart();
             }
             else
             {
                 frame_count++;
             }
         }
             
         public void restart()
         {
             current_segment = 0;
             frame_count = 0;
         }
     }

    /****************************LEG GESTURES************************************/

     public class Left_Leg_Step_Forward
     {
         readonly int num_of_frames = 1000;
         General_Gesture_Segment[] segments;

         int current_segment = 0;
         int frame_count = 0;

         public event EventHandler recognized_Left_Leg_Step_Forward;

         public Left_Leg_Step_Forward()
         {
             Left_Leg_Place_Low_Right_too left_leg_place_low_right_too = new Left_Leg_Place_Low_Right_too();
             Left_Leg_Low left_leg_low = new Left_Leg_Low();
             Left_Leg_Forward_Down left_leg_forward_down = new Left_Leg_Forward_Down();

             segments = new General_Gesture_Segment[]
            {
                left_leg_place_low_right_too,
                left_leg_low,
                left_leg_forward_down
            };
         }

         public void Update(Skeleton skeleton, Gestures_Names g)
         {
             int result = segments[current_segment].Update(skeleton);

             if (result == 0)
             {
                 if (current_segment + 1 < segments.Length)
                 {
                     current_segment++;
                     frame_count = 0;
                 }
                 else
                 {
                     if (recognized_Left_Leg_Step_Forward != null)
                     {
                         if (g.Name != gestures.LEFT_LEG_STEP_FORWARD)
                         {
                             g.Name = gestures.LEFT_LEG_STEP_FORWARD;
                             recognized_Left_Leg_Step_Forward(this, new EventArgs());
                             restart();
                         }
                     }
                 }
             }
             else if (result == 1 || frame_count == num_of_frames)
             {
                 restart();
             }
             else
             {
                 frame_count++;
             }
         }

         public void restart()
         {
             current_segment = 0;
             frame_count = 0;
         }
     }

     public class Left_Leg_Step_Forward_Right_Diagonal
     {
         readonly int num_of_frames = 1000;
         General_Gesture_Segment[] segments;

         int current_segment = 0;
         int frame_count = 0;

         public event EventHandler recognized_Left_Leg_Step_Forward_Right_Diagonal;

         public Left_Leg_Step_Forward_Right_Diagonal()
         {
             Left_Leg_Place_Low_Right_too left_leg_place_low_right_too = new Left_Leg_Place_Low_Right_too();
             Left_Leg_Low left_leg_low = new Left_Leg_Low();
             Left_Leg_Right_Forward_Diagonal left_leg_right_forward_diagonal = new Left_Leg_Right_Forward_Diagonal();

             segments = new General_Gesture_Segment[]
            {
                left_leg_place_low_right_too,
                left_leg_low,
                left_leg_right_forward_diagonal
            };
         }

         public void Update(Skeleton skeleton, Gestures_Names g)
         {
             int result = segments[current_segment].Update(skeleton);

             if (result == 0)
             {
                 if (current_segment + 1 < segments.Length)
                 {
                     current_segment++;
                     frame_count = 0;
                 }
                 else
                 {
                     if (recognized_Left_Leg_Step_Forward_Right_Diagonal != null)
                     {
                         if (g.Name != gestures.LEFT_LEG_STEP_FORWARD_RIGHT_DIAGONAL)
                         {
                             g.Name = gestures.LEFT_LEG_STEP_FORWARD_RIGHT_DIAGONAL;
                             recognized_Left_Leg_Step_Forward_Right_Diagonal(this, new EventArgs());
                             restart();
                         }
                     }
                 }
             }
             else if (result == 1 || frame_count == num_of_frames)
             {
                 restart();
             }
             else
             {
                 frame_count++;
             }
         }

         public void restart()
         {
             current_segment = 0;
             frame_count = 0;
         }
     }

     public class Left_Leg_Step_Backward_Right_Diagonal
     {
         readonly int num_of_frames = 1000;
         General_Gesture_Segment[] segments;

         int current_segment = 0;
         int frame_count = 0;

         public event EventHandler recognized_Left_Leg_Step_Backward_Right_Diagonal;

         public Left_Leg_Step_Backward_Right_Diagonal()
         {
             Left_Leg_Place_Low_Right_too left_leg_place_low_right_too = new Left_Leg_Place_Low_Right_too();
             Left_Leg_Low left_leg_low = new Left_Leg_Low();
             Left_Leg_Right_Backward_Diagonal left_leg_right_backward_diagonal = new Left_Leg_Right_Backward_Diagonal();

             segments = new General_Gesture_Segment[]
            {
                left_leg_place_low_right_too,
                left_leg_low,
                left_leg_right_backward_diagonal
            };
         }

         public void Update(Skeleton skeleton, Gestures_Names g)
         {
             int result = segments[current_segment].Update(skeleton);

             if (result == 0)
             {
                 if (current_segment + 1 < segments.Length)
                 {
                     current_segment++;
                     frame_count = 0;
                 }
                 else
                 {
                     if (recognized_Left_Leg_Step_Backward_Right_Diagonal != null)
                     {
                         if (g.Name != gestures.LEFT_LEG_STEP_BACKWARD_RIGHT_DIAGONAL)
                         {
                             g.Name = gestures.LEFT_LEG_STEP_BACKWARD_RIGHT_DIAGONAL;
                             recognized_Left_Leg_Step_Backward_Right_Diagonal(this, new EventArgs());
                             restart();
                         }
                     }
                 }
             }
             else if (result == 1 || frame_count == num_of_frames)
             {
                 restart();
             }
             else
             {
                 frame_count++;
             }
         }

         public void restart()
         {
             current_segment = 0;
             frame_count = 0;
         }
     }

     public class Left_Leg_Step_Forward_First_Pos_Backward
     {
         readonly int num_of_frames = 1000;
         General_Gesture_Segment[] segments;

         int current_segment = 0;
         int frame_count = 0;

         public event EventHandler recognized_Left_Leg_Step_Forward_First_Pos_Backward;

         public Left_Leg_Step_Forward_First_Pos_Backward()
         {
             Left_Leg_Backward_Down left_leg_backward_down = new Left_Leg_Backward_Down();
             Left_Leg_Low left_leg_low = new Left_Leg_Low();
             Left_Leg_Forward_Down left_leg_forward_down = new Left_Leg_Forward_Down();

             segments = new General_Gesture_Segment[]
            {
                left_leg_backward_down,
                left_leg_low,
                left_leg_forward_down
            };
         }

         public void Update(Skeleton skeleton, Gestures_Names g)
         {
             int result = segments[current_segment].Update(skeleton);

             if (result == 0)
             {
                 if (current_segment + 1 < segments.Length)
                 {
                     current_segment++;
                     frame_count = 0;
                 }
                 else
                 {
                     if (recognized_Left_Leg_Step_Forward_First_Pos_Backward != null)
                     {
                         if (g.Name != gestures.LEFT_LEG_STEP_FORWARD_FIRT_POS_BACKWARD)
                         {
                             g.Name = gestures.LEFT_LEG_STEP_FORWARD_FIRT_POS_BACKWARD;
                             recognized_Left_Leg_Step_Forward_First_Pos_Backward(this, new EventArgs());
                             restart();
                         }
                     }
                 }
             }
             else if (result == 1 || frame_count == num_of_frames)
             {
                 restart();
             }
             else
             {
                 frame_count++;
             }
         }

         public void restart()
         {
             current_segment = 0;
             frame_count = 0;
         }
     }

     public class Right_Leg_Step_Forward
     {
         readonly int num_of_frames = 1000;
         General_Gesture_Segment[] segments;

         int current_segment = 0;
         int frame_count = 0;

         public event EventHandler recognized_Right_Leg_Step_Forward;

         public Right_Leg_Step_Forward()
         {
             Right_Leg_Place_Low_Left_too right_leg_place_low_left_too = new Right_Leg_Place_Low_Left_too();
             Right_Leg_Low right_leg_low = new Right_Leg_Low();
             Right_Leg_Forward_Down right_leg_forward_down = new Right_Leg_Forward_Down();

             segments = new General_Gesture_Segment[]
            {
                right_leg_place_low_left_too,
                right_leg_low,
                right_leg_forward_down
            };
         }

         public void Update(Skeleton skeleton, Gestures_Names g)
         {
             int result = segments[current_segment].Update(skeleton);

             if (result == 0)
             {
                 if (current_segment + 1 < segments.Length)
                 {
                     current_segment++;
                     frame_count = 0;
                 }
                 else
                 {
                     if (recognized_Right_Leg_Step_Forward != null)
                     {
                         if (g.Name != gestures.RIGHT_LEG_STEP_FORWARD)
                         {
                             g.Name = gestures.RIGHT_LEG_STEP_FORWARD;
                             recognized_Right_Leg_Step_Forward(this, new EventArgs());
                             restart();
                         }
                     }
                 }
             }
             else if (result == 1 || frame_count == num_of_frames)
             {
                 restart();
             }
             else
             {
                 frame_count++;
             }
         }

         public void restart()
         {
             current_segment = 0;
             frame_count = 0;
         }
     }

     public class Right_Leg_Step_Forward_First_Pos_Backward
     {
         readonly int num_of_frames = 1000;
         General_Gesture_Segment[] segments;

         int current_segment = 0;
         int frame_count = 0;

         public event EventHandler recognized_Right_Leg_Step_Forward_First_Pos_Backward;

         public Right_Leg_Step_Forward_First_Pos_Backward()
         {
             Right_Leg_Backward_Down right_leg_backward_down = new Right_Leg_Backward_Down();
             Right_Leg_Low right_leg_low = new Right_Leg_Low();
             Right_Leg_Forward_Down right_leg_forward_down = new Right_Leg_Forward_Down();

             segments = new General_Gesture_Segment[]
            {
                right_leg_backward_down,
                right_leg_low,
                right_leg_forward_down
            };
         }

         public void Update(Skeleton skeleton, Gestures_Names g)
         {
             int result = segments[current_segment].Update(skeleton);

             if (result == 0)
             {
                 if (current_segment + 1 < segments.Length)
                 {
                     current_segment++;
                     frame_count = 0;
                 }
                 else
                 {
                     if (recognized_Right_Leg_Step_Forward_First_Pos_Backward != null)
                     {
                         if (g.Name != gestures.RIGHT_LEG_STEP_FORWARD_FIRST_POS_BACK)
                         {
                             g.Name = gestures.RIGHT_LEG_STEP_FORWARD_FIRST_POS_BACK;
                             recognized_Right_Leg_Step_Forward_First_Pos_Backward(this, new EventArgs());
                             restart();
                         }
                     }
                 }
             }
             else if (result == 1 || frame_count == num_of_frames)
             {
                 restart();
             }
             else
             {
                 frame_count++;
             }
         }

         public void restart()
         {
             current_segment = 0;
             frame_count = 0;
         }
     }

     
}