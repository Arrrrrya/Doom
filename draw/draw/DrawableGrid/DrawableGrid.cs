using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace draw {
    /// <summary>
    /// 
    /// 源代码来源：https://www.cnblogs.com/warnet/p/5491603.html?tdsourcetag=s_pcqq_aiomsg
    /// 
    /// 基本思想
    /// 1 在绘制结束时，计算相对于图片真实大小的情况下，绘制的矩形框的大小，及相对于图片的偏移
    /// 2 每次刷新绘制前，计算当前窗口大小，及应该绘制的图片的大小，及其偏移
    /// 3 每次刷新绘制前，计算绘制的矩形框，相对于当前图片的偏移
    /// 其中，
    /// 框的偏移及大小，每次使用针对原始图片的数据，作为基础来计算比例，就能够保证即使窗体缩小到0，依旧可以恢复
    /// </summary>
    public class DrawableGrid : Control {
        #region vars

        private Point mousedown;
        private Point mouseup;
        private bool mouseBtnDown = false;
        private bool bSelectionDraw = false;

        private SolidColorBrush mBrush = Brushes.LightBlue;
        private Pen mPen = new Pen(Brushes.Red, 1);
        private BitmapImage Img = null;

        private Grid drawgrid;

        private Rect curPicRect;
        private Rect curSelectRect;

        private Rect realSelectRect;
        private Rect realPicRect;

        #endregion

        #region ctors

        static DrawableGrid() {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(DrawableGrid), new FrameworkPropertyMetadata(typeof(DrawableGrid)));
        }

        #endregion

        #region overrides

        /// <summary>
        /// 重写绘制
        /// </summary>
        protected override void OnRender(DrawingContext drawingContext) {
            if(Img == null)
                return;

            curPicRect = CalcRect(Img.Height, Img.Width, this.ActualHeight, this.ActualWidth);
            curSelectRect = CalcResizeRect(curPicRect.X, curPicRect.Y, realSelectRect.X, realSelectRect.Y, realSelectRect.Height, realSelectRect.Width, curPicRect.Height / realPicRect.Height);

            drawingContext.DrawImage(Img, curPicRect);

            if(mouseBtnDown) {
                int xmin = (int)Math.Min(mousedown.X, mouseup.X);
                int xmax = (int)Math.Max(mousedown.X, mouseup.X);
                int ymin = (int)Math.Min(mousedown.Y, mouseup.Y);
                int ymax = (int)Math.Max(mousedown.Y, mouseup.Y);
                var r = new Rect(xmin, ymin, xmax - xmin, ymax - ymin);
                drawingContext.DrawRectangle(mBrush, mPen, r);
            }

            if(bSelectionDraw) {
                drawingContext.DrawRectangle(mBrush, mPen, curSelectRect);
            }

            base.OnRender(drawingContext);
        }

        public override void OnApplyTemplate() {
            drawgrid = GetTemplateChild("drawgrid") as Grid;
            if(drawgrid != null) {
                drawgrid.MouseDown += drawgrid_MouseDown;
                drawgrid.MouseMove += drawgrid_MouseMove;
                drawgrid.MouseUp += drawgrid_MouseUp;
            }

            string picaddr = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "pic", "2.jpg");
            Img = new BitmapImage(new Uri(picaddr));
            realPicRect = new Rect(0, 0, Img.Width, Img.Height);
        }

        #endregion

        #region methods

        /// <summary>
        /// 计算图片大小相对于当前的控件大小，应该如何展示
        /// </summary>
        /// <param name="imgHeight">图片高</param>
        /// <param name="imgWidth">图片宽</param>
        /// <param name="gridHeight">容器高</param>
        /// <param name="gridWidth">容器宽</param>
        /// <returns>当前实际应该绘制图片的矩形大小及相对于容器的偏移</returns>
        private Rect CalcRect(double imgHeight, double imgWidth, double gridHeight, double gridWidth) {
            Rect rect;
            double imgRatio = imgHeight / imgWidth;
            double gridRatio = gridHeight / gridWidth;

            if(imgRatio >= gridRatio) {
                double hi = gridHeight;
                double wi = gridHeight / imgRatio;

                double left = (gridWidth - wi) / 2;
                double top = 0;

                rect = new Rect(left, top, wi, hi);
            } else {
                double wi = gridWidth;
                double hi = gridWidth * imgRatio;

                double left = 0;
                double top = (gridHeight - hi) / 2;

                rect = new Rect(left, top, wi, hi);
            }

            return rect;
        }

        /// <summary>
        /// 在图片上绘制的框相对于图片的位置
        /// </summary>
        private Rect CalcResizeRect(double curx, double cury, double lastx, double lasty, double lastheight, double lastwidth, double ratio) {
            double x = curx + lastx * ratio;
            double y = cury + lasty * ratio;
            double wid = lastwidth * ratio;
            double hei = lastheight * ratio;
            return new Rect(x, y, wid, hei);
        }

        #endregion

        #region events

        private void drawgrid_MouseDown(object sender, MouseButtonEventArgs e) {
            if(e.LeftButton == MouseButtonState.Pressed && e.RightButton == MouseButtonState.Released) {
                bSelectionDraw = false;
                mouseBtnDown = true;
                mousedown = e.GetPosition(drawgrid);
            }
        }

        private void drawgrid_MouseMove(object sender, MouseEventArgs e) {
            if(mouseBtnDown) {
                mouseup = e.GetPosition(drawgrid);
                this.InvalidateVisual();
            }
        }

        private void drawgrid_MouseUp(object sender, MouseButtonEventArgs e) {
            if(e.LeftButton == MouseButtonState.Released && e.RightButton == MouseButtonState.Released) {
                bSelectionDraw = true;
                mouseBtnDown = false;
                mouseup = e.GetPosition(drawgrid);

                int xmin = (int)Math.Min(mousedown.X, mouseup.X);
                int xmax = (int)Math.Max(mousedown.X, mouseup.X);
                int ymin = (int)Math.Min(mousedown.Y, mouseup.Y);
                int ymax = (int)Math.Max(mousedown.Y, mouseup.Y);

                var relativeRect = new Rect(xmin, ymin, xmax - xmin, ymax - ymin);
                var fullSizeImgRect = CalcRect(Img.Height, Img.Width, Img.Height, Img.Width);
                double tempration = fullSizeImgRect.Height / curPicRect.Height;
                realSelectRect = CalcResizeRect(fullSizeImgRect.X, fullSizeImgRect.Y, relativeRect.X - curPicRect.X, relativeRect.Y - curPicRect.Y, relativeRect.Height, relativeRect.Width, tempration);
            }
        }

        #endregion
    }
}