﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;

namespace WinCamera
{
    /// <summary>
    /// webcam 的摘要说明。
    /// </summary>
    public class webcam
    {
        private const int WM_USER = 0x400;
        private const int WS_CHILD = 0x40000000;
        private const int WS_VISIBLE = 0x10000000;
        private const int WM_CAP_START = WM_USER;
        private const int WM_CAP_STOP = WM_CAP_START + 68;
        private const int WM_CAP_DRIVER_CONNECT = WM_CAP_START + 10;
        private const int WM_CAP_DRIVER_DISCONNECT = WM_CAP_START + 11;
        private const int WM_CAP_SAVEDIB = WM_CAP_START + 25;
        private const int WM_CAP_GRAB_FRAME = WM_CAP_START + 60;
        private const int WM_CAP_SEQUENCE = WM_CAP_START + 62;
        private const int WM_CAP_FILE_SET_CAPTURE_FILEA = WM_CAP_START + 20;
        private const int WM_CAP_SEQUENCE_NOFILE = WM_CAP_START + 63;
        private const int WM_CAP_SET_OVERLAY = WM_CAP_START + 51;
        private const int WM_CAP_SET_PREVIEW = WM_CAP_START + 50;
        private const int WM_CAP_SET_CALLBACK_VIDEOSTREAM = WM_CAP_START + 6;
        private const int WM_CAP_SET_CALLBACK_ERROR = WM_CAP_START + 2;
        private const int WM_CAP_SET_CALLBACK_STATUSA = WM_CAP_START + 3;
        private const int WM_CAP_SET_CALLBACK_FRAME = WM_CAP_START + 5;
        private const int WM_CAP_SET_SCALE = WM_CAP_START + 53;
        private const int WM_CAP_SET_PREVIEWRATE = WM_CAP_START + 52;
        private IntPtr hWndC;
        private bool bStat = false;

        private IntPtr mControlPtr;
        public int Width;
        public int Height;
        private int mLeft;
        private int mTop;

        public string GrabImagePath = "";
        public string KinescopePath = "";

        /// <summary>
        /// 初始化摄像头
        /// </summary>
        /// <param name="handle">控件的句柄</param>
        /// <param name="left">开始显示的左边距</param>
        /// <param name="top">开始显示的上边距</param>
        /// <param name="width">要显示的宽度</param>
        /// <param name="height">要显示的长度</param>
        public webcam(IntPtr handle, int left, int top, int width, int height)
        {
            mControlPtr = handle;
            Width = width;
            Height = height;
            mLeft = left;
            mTop = top;
        }

        [DllImport("avicap32.dll")]
        private static extern IntPtr capCreateCaptureWindowA(byte[] lpszWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, int nID);

        [DllImport("avicap32.dll")]
        private static extern int capGetVideoFormat(IntPtr hWnd, IntPtr psVideoFormat, int wSize);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, IntPtr lParam);

        /// <summary>
        /// 开始显示图像
        /// </summary>
        public void Start()
        {
            if (bStat)
                return;

            bStat = true;
            byte[] lpszName = new byte[100];

            hWndC = capCreateCaptureWindowA(lpszName, WS_CHILD | WS_VISIBLE, mLeft, mTop, Width, Height, mControlPtr, 0);

            if (hWndC.ToInt32() != 0)
            {
                SendMessage(hWndC, WM_CAP_SET_CALLBACK_VIDEOSTREAM, 0, IntPtr.Zero);
                SendMessage(hWndC, WM_CAP_SET_CALLBACK_ERROR, 0, IntPtr.Zero);
                SendMessage(hWndC, WM_CAP_SET_CALLBACK_STATUSA, 0, IntPtr.Zero);
                SendMessage(hWndC, WM_CAP_DRIVER_CONNECT, 0, IntPtr.Zero);
                SendMessage(hWndC, WM_CAP_SET_SCALE, 1, IntPtr.Zero);
                SendMessage(hWndC, WM_CAP_SET_PREVIEWRATE, 66, IntPtr.Zero);
                SendMessage(hWndC, WM_CAP_SET_OVERLAY, 1, IntPtr.Zero);
                SendMessage(hWndC, WM_CAP_SET_PREVIEW, 1, IntPtr.Zero);
            }
            return;
        }

        /// <summary>
        /// 停止显示
        /// </summary>
        public void Stop()
        {
            SendMessage(hWndC, WM_CAP_DRIVER_DISCONNECT, 0, IntPtr.Zero);
            bStat = false;
        }

        /// <summary>
        /// 抓图
        /// </summary>
        /// <param name="path">要保存bmp文件的路径</param>
        public void GrabImage()
        {
            IntPtr hBmp = Marshal.StringToHGlobalAnsi(GrabImagePath);
            SendMessage(hWndC, WM_CAP_SAVEDIB, 0, hBmp);

        }

        /// <summary>
        /// 录像
        /// </summary>
        /// <param name="path">要保存avi文件的路径</param>
        public void Kinescope()
        {
            IntPtr hBmp = Marshal.StringToHGlobalAnsi(KinescopePath);
            SendMessage(hWndC, WM_CAP_FILE_SET_CAPTURE_FILEA, 0, hBmp);
            SendMessage(hWndC, WM_CAP_SEQUENCE, 0, IntPtr.Zero);
        }

        /// <summary>
        /// 停止录像
        /// </summary>
        public void StopKinescope()
        {
            SendMessage(hWndC, WM_CAP_STOP, 0, IntPtr.Zero);
        }
    }
}