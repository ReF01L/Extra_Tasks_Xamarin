using System;
using System.Collections.Generic;
using System.Text;
using Android.Content;
using Android.Graphics;
using Extra_Task.ExtraTask_2;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(ExtraTask_2), typeof(ExtraTask_2_Render))]
namespace Extra_Task.ExtraTask_2
{
    class ExtraTask_2_Render : VisualElementRenderer<StackLayout>
    {
        public ExtraTask_2_Render(Context context) : base(context) {}
        private Xamarin.Forms.Color StartColor { get; set; }
        private Xamarin.Forms.Color EndColor { get; set; }
        protected override void DispatchDraw(Canvas canvas)
        {
            var gradient = new LinearGradient(0, 0, Width, 0, StartColor.ToAndroid(), EndColor.ToAndroid(), Shader.TileMode.Mirror);

            var paint = new Paint();
            paint.SetShader(gradient);
            canvas.DrawPaint(paint);
            base.DispatchDraw(canvas);
        }
        protected override void OnElementChanged(ElementChangedEventArgs<StackLayout> e)
        {
            base.OnElementChanged(e);

            var stack = e.NewElement as ExtraTask_2;
            this.StartColor = stack.StartColor;
            this.EndColor = stack.EndColor;
        }
    }
}
