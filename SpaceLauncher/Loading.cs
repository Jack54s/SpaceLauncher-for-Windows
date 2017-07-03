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
        }

        //Create a Bitmpap Object.
        Bitmap animatedImage = new Bitmap(@"../../Rocket.gif");
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
