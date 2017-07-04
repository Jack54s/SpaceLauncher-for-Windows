using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpaceLauncher
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
            if (ImageAnimator.CanAnimate(animatedImage))
            {
                frameCount = animatedImage.GetFrameCount(new System.Drawing.Imaging.FrameDimension(animatedImage.FrameDimensionsList[0]));
            }
            try
            {
                animatedImage = new Bitmap(@"Rocket.gif");
            }
            catch(Exception ioe)
            {
                MessageBox.Show("请将Rocket.gif放在与SpaceLauncher同目录下！");
                HotKey.UnregisterHotKey(Handle, 101);
                Application.Exit();
            }
        }

        //Create a Bitmpap Object.
        Bitmap animatedImage;
        bool currentlyAnimating = false;
        int frameCount = 1;

        //This method begins the animation.
        public void AnimateImage()
        {
            if (!currentlyAnimating)
            {

                //Begin the animation only once.
                ImageAnimator.Animate(animatedImage, new EventHandler(this.OnFrameChanged));
                currentlyAnimating = true;
            }
        }

        //This method stops the animation.
        public void StopAnimate()
        {
            if (currentlyAnimating)
            {
                ImageAnimator.StopAnimate(animatedImage, new EventHandler(this.OnFrameChanged));
                currentlyAnimating = false;
            }
        }

        //Reset image.
        public void ResetImage()
        {
            StopAnimate();
            animatedImage.SelectActiveFrame(new System.Drawing.Imaging.FrameDimension(animatedImage.FrameDimensionsList[0]), 0);
        }

        private void OnFrameChanged(object o, EventArgs e)
        {

            //Force a call to the Paint event handler.
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //AnimateImage();
            //Get the next frame ready for rendering.
            ImageAnimator.UpdateFrames();

            //Draw the next frame in the animation.
            e.Graphics.DrawImage(this.animatedImage, new Point(0, 0));
        }
    }
}
