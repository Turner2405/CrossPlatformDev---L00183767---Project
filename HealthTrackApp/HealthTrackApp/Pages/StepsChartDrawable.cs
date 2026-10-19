namespace HealthTrackApp.Pages
{
    using Microsoft.Maui.Graphics;

        public class StepsChartDrawable : IDrawable
    {
                private readonly string[] days =
            { "Mon","Tue","Wed","Thu","Fri","Sat","Sun"};

                private readonly int[] steps =
             { 23567,12000,14567,3413,12000,1088,11000};

                public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            float width = dirtyRect.Width;
            float height = dirtyRect.Height;

            float left = 35;
            float top = 10;
            float bottom = height - 30;
            float chartHeight = bottom - top;

            float maxSteps = 25000;
            float slotWidth = (width - left - 10) / 7;
            float barWidth = slotWidth * 0.55f;

            canvas.FontSize = 10;
            canvas.FontColor = Color.FromArgb("#777777");

            for (int i = 0; i <= 6; i++)
            {
                float value = i * 5000;
                float y = bottom - (value / maxSteps) * chartHeight;

                canvas.DrawString(
                    value.ToString("N0"),
                    0, y - 7, left + 5, 15,
                    HorizontalAlignment.Left,
                    VerticalAlignment.Center);
            }

            for (int i = 0; i < steps.Length; i++)
            {
                float barHeight = (steps[i] / maxSteps) * chartHeight;
                float x = left + i * slotWidth
                          + (slotWidth - barWidth) / 2;

                float y = bottom - barHeight;

                canvas.FillColor = Color.FromArgb("#00A6A6");

                canvas.FillRoundedRectangle(
                    x, y, barWidth, barHeight, 5);

                canvas.DrawString(
                    days[i],
                    x - 5, bottom + 5, barWidth + 10, 20,
                    HorizontalAlignment.Center,
                    VerticalAlignment.Center);
            }
        }
    }
}
