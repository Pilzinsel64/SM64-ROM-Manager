using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using global::DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using global::Pilz.Drawing.Drawing3D.OpenGLFactory.CameraN;

namespace SM64_ROM_Manager.LevelEditor
{
    public class ObjectControlling
    {
        private Form_AreaEditor _Main;

        private Form_AreaEditor Main
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Main;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                _Main = value;
            }
        }

        private List<System.Numerics.Vector3> moveObj_saved = new List<System.Numerics.Vector3>();
        private bool moveObj_mouseDown = false;
        private int moveObj_lastMouseX = 0;
        private int moveObj_lastMouseY = 0;
        private bool moveObj_UpDown_mouseDown = false;
        private int moveObj_UpDown_lastMouseY = 0;
        private bool rotObj_mouseDown = false;
        private int rotObj_lastMouseX = 0;
        private int rotObj_lastMouseY = 0;
        private int rotObj_Yaw_lastMouseY = 0;
        private bool rotObj_Yaw_mouseDown = false;
        private int moveCam_InOut_lastPosY = 0;
        private bool moveCam_InOut_mouseDown = false;
        private bool moveCam_strafe_mouseDown = false;

        public bool WasInOrbitMode { get; set; } = false;

        public ObjectControlling(Form_AreaEditor main)
        {
            Main = main;
            AddHandlers();
        }

        private void AddHandlers()
        {
            Main.PictureBox_ObjCntrWheel.MouseDown += PictureBox_ObjCntrWheel_MouseDown;
            Main.PictureBox_ObjCntrWheel.MouseUp += PictureBox_ObjCntrWheel_MouseUp;
            Main.PictureBox_ObjCntrWheel.MouseMove += PictureBox_ObjCntrWheel_MouseMove;
            Main.PictureBox_ObjCntrCross.MouseDown += PictureBox_ObjCntrCross_MouseDown;
            Main.PictureBox_ObjCntrCross.MouseUp += PictureBox_ObjCntrCross_MouseUp;
            Main.PictureBox_ObjCntrCross.MouseMove += PictureBox_ObjCntrCross_MouseMove;
            Main.PictureBox_ObjRotWheel.MouseDown += PictureBox_ObjRotWheel_MouseDown;
            Main.PictureBox_ObjRotWheel.MouseUp += PictureBox_ObjRotWheel_MouseUp;
            Main.PictureBox_ObjRotWheel.MouseMove += PictureBox_ObjRotWheel_MouseMove;
            Main.PictureBox_ObjRotCross.MouseDown += PictureBox_ObjRotCross_MouseDown;
            Main.PictureBox_ObjRotCross.MouseUp += PictureBox_ObjRotCross_MouseUp;
            Main.PictureBox_ObjRotCross.MouseMove += PictureBox_ObjRotCross_MouseMove;
            Main.PictureBox_CamCntrWheel.MouseDown += PictureBox_CamCntrWheel_MouseDown;
            Main.PictureBox_CamCntrWheel.MouseUp += PictureBox_CamCntrWheel_MouseUp;
            Main.PictureBox_CamCntrWheel.MouseMove += PictureBox_CamCntrWheel_MouseMove;
            Main.PictureBox_CamMoveCross.MouseDown += PictureBox_CamMoveCross_MouseDown;
            Main.PictureBox_CamMoveCross.MouseUp += PictureBox_CamMoveCross_MouseUp;
            Main.PictureBox_CamMoveCross.MouseMove += PictureBox_CamMoveCross_MouseMove;
            Main.Camera.NeedSelectedObject += Camera_NeedSelectedObject;
        }

        private void SaveObjectPositionToList()
        {
            moveObj_saved.Clear();
            foreach (Managed3DObject obj in Main.SelectedObjects)
                moveObj_saved.Add(obj.Position);
        }

        private void SaveObjectRotationToList()
        {
            moveObj_saved.Clear();
            foreach (Managed3DObject obj in Main.SelectedObjects)
                moveObj_saved.Add(obj.Rotation);
        }

        public void PictureBox_ObjCntrWheel_MouseDown(object sender, MouseEventArgs e)
        {
            moveObj_UpDown_lastMouseY = e.Y;
            SaveObjectPositionToList();
            Main.StoreObjectHistoryPoint(Main.SelectedObjects, nameof(Managed3DObject.Position));
            moveObj_UpDown_mouseDown = true;
        }

        public void PictureBox_ObjCntrWheel_MouseUp(object sender, MouseEventArgs e)
        {
            moveObj_UpDown_mouseDown = false;
        }

        public void PictureBox_ObjCntrWheel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveObj_UpDown_mouseDown)
            {
                for (int mo_s_incr = 0, loopTo = Main.SelectedObjects.Length - 1; mo_s_incr <= loopTo; mo_s_incr++)
                {
                    var obj = Main.SelectedObjects[mo_s_incr];
                    if (Main.EnableSlideMovementForObjects)
                    {
                        var zeroPoint = Main.PictureBox_ObjCntrWheel.PointToScreen(new Point(0, Main.PictureBox_ObjCntrWheel.Height / 2));
                        SlideMoveObjectY(obj, (sender as Control).PointToScreen(e.Location), zeroPoint, moveObj_saved[mo_s_incr], false);
                    }
                    else
                        moveObjectY(obj, e.Location, moveObj_saved[mo_s_incr], false);
                }

                if (Main.KeepObjectOnGround)
                {
                    Main.KeepObjectsOnGround();
                }
                else
                {
                    Main.AdvPropertyGrid1_RefreshPropertyValues();
                }

                Main.ogl.GLControl.Invalidate();
            }
        }

        public void PictureBox_ObjCntrCross_MouseDown(object sender, MouseEventArgs e)
        {
            if (Main.EditObjects && Main.SelectedObject is object)
            {
                var objs = Main.SelectedObjects;
                if (objs.Length == 0)
                    return;
                Main.StoreObjectHistoryPoint(objs, "Position");
                moveObj_mouseDown = true;
                moveObj_lastMouseX = e.X;
                moveObj_lastMouseY = e.Y;
                SaveObjectPositionToList();
            }
        }

        public void PictureBox_ObjCntrCross_MouseUp(object sender, MouseEventArgs e)
        {
            moveObj_mouseDown = false;
        }

        public void PictureBox_ObjCntrCross_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveObj_mouseDown)
            {
                if (Main.EditObjects && Main.SelectedObject is object)
                {
                    int mo_s_incr = 0;
                    foreach (object obj in Main.SelectedObjects)
                    {
                        if (Main.EnableSlideMovementForObjects)
                        {
                            var zeroPoint = Main.PictureBox_ObjCntrCross.PointToScreen(new Point(Main.PictureBox_ObjCntrCross.Width / 2, Main.PictureBox_ObjCntrCross.Height / 2));
                            SlideMoveObjectXZ((Managed3DObject)obj, Cursor.Position, zeroPoint, moveObj_saved[mo_s_incr], false);
                        }
                        else
                            moveObjectXZ((Managed3DObject)obj, ((Control)sender).PointToClient(Cursor.Position), moveObj_saved[mo_s_incr], false);
                        mo_s_incr += 1;
                    }

                    Main.KeepObjectsOnGround();
                    Main.AdvPropertyGrid1_RefreshPropertyValues();
                    Main.ogl.GLControl.Invalidate();
                }
            }
        }

        private void moveObjectY(Managed3DObject obj, Point e, System.Numerics.Vector3 savedPos, bool forRotation)
        {
            if (!forRotation)
            {
                short newY = Conversions.ToShort(-Math.Truncate(30 * (e.Y - moveObj_UpDown_lastMouseY) * Main.ObjectMoveSpeed));
                obj.Position = new System.Numerics.Vector3(obj.Position.X, savedPos.Y + newY, obj.Position.Z);
            }
            else
            {
                short newY = Conversions.ToShort(-Math.Truncate((double)(e.Y - rotObj_Yaw_lastMouseY)));
                RotateObject(obj, new System.Numerics.Vector3(obj.Rotation.X, newY, obj.Rotation.Z));
            }

            Main.ogl.UpdateOrbitCamera();
        }

        private void SlideMoveObjectY(Managed3DObject obj, Point e, Point zeroPoint, System.Numerics.Vector3 savedPos, bool forRotation)
        {
            var mvy = zeroPoint.Y - e.Y;
            if (mvy < zeroPoint.Y) mvy = -mvy;

            if (!forRotation)
            {
                short newY = Conversions.ToShort(obj.PositionY - Conversions.ToShort(Math.Truncate(mvy * Main.ObjectMoveSpeed)));
                obj.Position = new System.Numerics.Vector3(obj.Position.X, newY, obj.Position.Z);
            }
            else
            {
                short newY = Conversions.ToShort(-Math.Truncate(0.5F * mvy));
                RotateObject(obj, new System.Numerics.Vector3(obj.Rotation.X, newY, obj.Rotation.Z));
            }

            Main.ogl.UpdateOrbitCamera();
        }

        private void moveObjectXZ(Managed3DObject obj, Point e, System.Numerics.Vector3 savedPos, bool forRotation)
        {
            float speedMult = 30.0F;
            int mx, my;
            if (!forRotation)
            {
                mx = e.X - moveObj_lastMouseX;
                my = -(e.Y - moveObj_lastMouseY);
            }
            else
            {
                mx = e.X - rotObj_lastMouseX;
                my = -(e.Y - rotObj_lastMouseY);
            }

            float CX = Conversions.ToSingle(Math.Sin(Main.Camera.Yaw));
            float CZ = Conversions.ToSingle(-Math.Cos(Main.Camera.Yaw));
            float CX_2 = Conversions.ToSingle(Math.Sin(Main.Camera.Yaw + Math.PI / 2));
            float CZ_2 = Conversions.ToSingle(-Math.Cos(Main.Camera.Yaw + Math.PI / 2));
            float newX, newZ;
            float moveSpeed = forRotation ? 1 : Main.ObjectMoveSpeed;
            newX = Conversions.ToSingle(Math.Truncate(savedPos.X - Conversions.ToShort(Math.Truncate(CX * my * speedMult * moveSpeed)) - Conversions.ToShort(Math.Truncate(CX_2 * mx * speedMult * moveSpeed))));
            newZ = Conversions.ToSingle(Math.Truncate(savedPos.Z - Conversions.ToShort(Math.Truncate(CZ * my * speedMult * moveSpeed)) - Conversions.ToShort(Math.Truncate(CZ_2 * mx * speedMult * moveSpeed))));
            if (!forRotation)
            {
                var oldPos = obj.Position;
                var newPos = new System.Numerics.Vector3(Conversions.ToShort(newX), oldPos.Y, Conversions.ToShort(newZ));
                SetObjectPosition(obj, newPos);
            }
            else
            {
                speedMult = 0.5F;
                var oldRot = obj.Rotation;
                var newRot = new System.Numerics.Vector3(newX, oldRot.Y, newZ);
                SetObjectRotation(obj, newRot);
            }

            Main.ogl.UpdateOrbitCamera();
        }

        private void SlideMoveObjectXZ(Managed3DObject obj, Point e, Point zeroPoint, System.Numerics.Vector3 savedPos, bool forRotation)
        {
            int mx, my;

            mx = zeroPoint.X - e.X;
            if (mx < zeroPoint.X) mx = -mx;

            my = zeroPoint.Y - e.Y;
            if (my < zeroPoint.Y) my = -my;

            float newX, newZ;
            System.Numerics.Vector3 oldPos;

            if (!forRotation)
                oldPos = obj.Position;
            else
                oldPos = obj.Rotation;

            float CX = Conversions.ToSingle(Math.Sin(Main.Camera.Yaw));
            float CZ = Conversions.ToSingle(Math.Cos(Main.Camera.Yaw));
            float CX_2 = Conversions.ToSingle(Math.Sin(Main.Camera.Yaw + Math.PI / 2));
            float CZ_2 = Conversions.ToSingle(Math.Cos(Main.Camera.Yaw + Math.PI / 2));
            newX = Conversions.ToSingle(Math.Truncate(oldPos.X - Conversions.ToShort(Math.Truncate(CX * mx * Main.ObjectMoveSpeed)) - Conversions.ToShort(Math.Truncate(CX_2 * mx * Main.ObjectMoveSpeed))));
            newZ = Conversions.ToSingle(Math.Truncate(oldPos.Z - Conversions.ToShort(Math.Truncate(CZ * my * Main.ObjectMoveSpeed)) - Conversions.ToShort(Math.Truncate(CZ_2 * my * Main.ObjectMoveSpeed))));

            if (!forRotation)
            {
                var newPos = new System.Numerics.Vector3(Conversions.ToShort(newX), oldPos.Y, Conversions.ToShort(newZ));
                SetObjectPosition(obj, newPos);
            }
            else
            {
                var newRot = new System.Numerics.Vector3(newX, oldPos.Y, newZ);
                SetObjectRotation(obj, newRot);
            }

            Main.ogl.UpdateOrbitCamera();
        }

        private void MoveObject(Managed3DObject obj, System.Numerics.Vector3 val)
        {
            obj.Position = new System.Numerics.Vector3(obj.Position.X + val.X, obj.Position.Y + val.Y, obj.Position.Z + val.Z);
        }

        private void SetObjectPosition(Managed3DObject obj, System.Numerics.Vector3 pos)
        {
            obj.Position = pos;
        }

        private void RotateObject(Managed3DObject obj, System.Numerics.Vector3 val)
        {
            obj.Rotation = new System.Numerics.Vector3(Publics.General.KeepDegreesWithin360(Conversions.ToShort(obj.Rotation.X + val.X)), Publics.General.KeepDegreesWithin360(Conversions.ToShort(obj.Rotation.Y + val.Y)), Publics.General.KeepDegreesWithin360(Conversions.ToShort(obj.Rotation.Z + val.Z)));
        }

        private void SetObjectRotation(Managed3DObject obj, System.Numerics.Vector3 rot)
        {
            obj.Rotation = new System.Numerics.Vector3(Publics.General.KeepDegreesWithin360(Conversions.ToShort(rot.X)), Publics.General.KeepDegreesWithin360(Conversions.ToShort(rot.Y)), Publics.General.KeepDegreesWithin360(Conversions.ToShort(rot.Z)));
        }

        private void PictureBox_ObjRotWheel_MouseDown(object sender, MouseEventArgs e)
        {
            if (Main.EditObjects && Main.SelectedObject is object)
            {
                rotObj_Yaw_lastMouseY = e.Y;
                SaveObjectRotationToList();
                Main.StoreObjectHistoryPoint(Main.SelectedObjects, nameof(Managed3DObject.Rotation));
                rotObj_Yaw_mouseDown = true;
            }
        }

        private void PictureBox_ObjRotWheel_MouseUp(object sender, MouseEventArgs e)
        {
            rotObj_Yaw_mouseDown = false;
        }

        private void PictureBox_ObjRotWheel_MouseMove(object sender, MouseEventArgs e)
        {
            if (rotObj_Yaw_mouseDown)
            {
                if (Main.EditObjects && Main.SelectedObject is object)
                {
                    for (int mo_s_incr = 0, loopTo = Main.SelectedObjects.Length - 1; mo_s_incr <= loopTo; mo_s_incr++)
                    {
                        var obj = Main.SelectedObjects.ElementAtOrDefault(mo_s_incr);
                        if (obj is object)
                        {
                            if (Main.EnableSlideMovementForObjects)
                                SlideMoveObjectY(obj, (sender as Control).PointToScreen(e.Location), Main.PictureBox_ObjCntrWheel.PointToScreen(new Point(0, Main.PictureBox_ObjCntrWheel.Height / 2)), moveObj_saved[mo_s_incr], true);
                            else
                                moveObjectY(obj, e.Location, moveObj_saved[mo_s_incr], true);
                        }
                    }

                    Main.ogl.Invalidate();
                    rotObj_Yaw_lastMouseY = e.Y;
                    Main.AdvPropertyGrid1_RefreshPropertyValues();
                }
            }
        }

        private void PictureBox_ObjRotCross_MouseDown(object sender, MouseEventArgs e)
        {
            if (Main.EditObjects && Main.SelectedObject is object)
            {
                Main.StoreObjectHistoryPoint(Main.SelectedObjects, nameof(Managed3DObject.Rotation));
                rotObj_mouseDown = true;
                rotObj_lastMouseX = e.X;
                rotObj_lastMouseY = e.Y;
                SaveObjectRotationToList();
            }
        }

        private void PictureBox_ObjRotCross_MouseUp(object sender, MouseEventArgs e)
        {
            rotObj_mouseDown = false;
        }

        private void PictureBox_ObjRotCross_MouseMove(object sender, MouseEventArgs e)
        {
            if (rotObj_mouseDown)
            {
                if (Main.EditObjects && Main.SelectedObject is object)
                {
                    for (int mo_s_incr = 0, loopTo = Main.SelectedObjects.Length - 1; mo_s_incr <= loopTo; mo_s_incr++)
                    {
                        var obj = Main.SelectedObjects.ElementAtOrDefault(mo_s_incr);
                        if (obj is object)
                        {
                            if (Main.EnableSlideMovementForObjects)
                            {
                                var zeroPoint = Main.PictureBox_ObjRotCross.PointToScreen(new Point(Main.PictureBox_ObjRotCross.Width / 2, Main.PictureBox_ObjRotCross.Height / 2));
                                SlideMoveObjectXZ((Managed3DObject)obj, Cursor.Position, zeroPoint, moveObj_saved[mo_s_incr], true);
                            }
                            else
                                moveObjectXZ(obj, ((Control)sender).PointToClient(Cursor.Position), moveObj_saved[mo_s_incr], true);
                            mo_s_incr += 1;
                        }
                    }

                    Main.KeepObjectsOnGround();
                    Main.ogl.Invalidate();
                    Main.AdvPropertyGrid1_RefreshPropertyValues();
                }
            }
        }

        private void PictureBox_CamCntrWheel_MouseDown(object sender, MouseEventArgs e)
        {
            moveCam_InOut_mouseDown = true;
            moveCam_InOut_lastPosY = e.Y;
        }

        private void PictureBox_CamCntrWheel_MouseUp(object sender, MouseEventArgs e)
        {
            moveCam_InOut_mouseDown = false;
        }

        private void PictureBox_CamCntrWheel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveCam_InOut_mouseDown)
            {
                Main.Camera.ResetMouseStuff();
                Main.Camera.UpdateCameraMatrixWithScrollWheel((e.Y - moveCam_InOut_lastPosY) * -10, ref Main.ogl.camMtx);
                Main.ogl.savedCamPos = Main.Camera.Position;
                moveCam_InOut_lastPosY = e.Y;
                Main.ogl.Invalidate();
            }
        }

        private void PictureBox_CamMoveCross_MouseDown(object sender, MouseEventArgs e)
        {
            Main.ogl.savedCamPos = Main.Camera.Position;
            moveCam_strafe_mouseDown = true;
        }

        private void PictureBox_CamMoveCross_MouseUp(object sender, MouseEventArgs e)
        {
            Main.Camera.ResetMouseStuff();
            moveCam_strafe_mouseDown = false;
        }

        private void PictureBox_CamMoveCross_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveCam_strafe_mouseDown)
            {
                Main.Camera.UpdateCameraOffsetWithMouse(Main.ogl.savedCamPos, e.X, e.Y, Main.ogl.GLControl.Width, Main.ogl.GLControl.Height, ref Main.ogl.camMtx);
                Main.ogl.Invalidate();
            }
        }

        private void Camera_NeedSelectedObject(object sender, Camera.NeedSelectedObjectEventArgs e)
        {
            var needSelectedObject = default(bool);
            Main.Invoke(new Action(() => needSelectedObject = Main.SelectedObject is object));
            if (needSelectedObject)
            {
                Main.Invoke(new Action(() => e.Points = Main.SelectedObjects));
            }
            else if (Main.Camera.CamMode == CameraMode.ORBIT)
            {
                Main.ogl.SetCameraMode(CameraMode.FLY);
                WasInOrbitMode = true;
            }
        }
    }
}