using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;

namespace ProyectoIntegradorTaller.views.components
{
    internal class BotonPersonalisado : Button
    {
        // Campos para almacenar configuraciones del botón
        private int borderSize = 0;
        private int borderRadius = 6;
        private Color borderColor = Color.PaleVioletRed;
        

        // Propiedades para configurar el botón
        [Category("Personalisado")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate(); // Forzar repintado al cambiar el tamaño del borde
            }
        }

        [Category("Personalisado")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate(); // Forzar repintado al cambiar el radio de las esquinas
            }
        }

        [Category("Personalisado")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate(); // Forzar repintado al cambiar el color del borde
            }
        }

        [Category("Personalisado")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; } // Establecer el color de fondo del botón
        }

        [Category("Personalisado")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; } // Establecer el color del texto del botón
        }

        // Constructor de la clase
        public BotonPersonalisado()
        {
            // Configuración inicial del botón
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.FromArgb(17, 97, 238);
            this.ForeColor = Color.White;

            // Suscripción al evento Resize para manejar cambios de tamaño
            this.Resize += new EventHandler(Button_Resize);
        }

        // Método para obtener un camino gráfico con esquinas redondeadas
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        // Método para pintar el botón personalizado
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            // Obtener rectángulos para superficie y borde
            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;

            // Ajustar el tamaño suavizado si el tamaño del borde es mayor que cero
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) // Botón con bordes redondeados
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    // Establecer la región para la superficie del botón
                    this.Region = new Region(pathSurface);
                    // Dibujar la superficie del botón
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    // Dibujar el borde del botón
                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else // Botón sin bordes redondeados
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                // Establecer la región para la superficie del botón
                this.Region = new Region(rectSurface);

                // Dibujar el borde del botón
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        // Método llamado cuando se crea el control
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            // Suscribirse al evento BackColorChanged del contenedor principal
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        // Método para manejar cambios en el color de fondo del contenedor
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate(); // Forzar repintado cuando cambia el color de fondo
        }

        // Método para manejar el redimensionamiento del botón
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height; // Asegurar que el radio no sea mayor que la altura
        }
    }
}