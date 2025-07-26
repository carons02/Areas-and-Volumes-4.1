using CircleAreaDLL;
using ConeAreaDLL;
using ConeVolumeDLL;
using CubeVolumeDLL;
using CylinderVolumeDLL;
using ParallelepipedVolumeDLL;
using PolygonAreaDLL;
using RectangleAreaDLL;
using RegularPrismVolumeDLL;
using RhombusAreaDLL;
using SphereAreaDLL;
using SphereVolumeDLL;
using SquareAreaDLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrapezoidAreaDLL;
using TriangleAreaDLL;

namespace AreasAndVolumes
    
{
    public partial class AreasAndVolumes : Form
    {
        //establishing all the variables used throughout all the 15 equations for areas and volumes. Also the string for which equation is selected
        decimal length = 0;
        decimal width = 0;
        decimal height = 0;
        decimal radius = 0;
        decimal baselength = 0;
        decimal perimeter = 0;
        decimal smalldiagonal = 0;
        decimal largediagonal = 0;
        decimal largeside = 0;
        decimal smallside = 0;
        decimal apothem = 0;
        decimal side = 0;
        decimal slantheight = 0;
        decimal area = 0;
        decimal volume = 0;
        decimal pi = 3.14159m;
        string selectedequation = "";
        public AreasAndVolumes()
        {
           //Initialized the program and show all of the text boxes avaialbe for the equations.
            InitializeComponent();
            LenghtTextBox.Show();
            WidthTextBox.Show();
            HeightTextBox.Show();
            BaseTextBox.Show();
            PerimeterTextBox.Show();
            RadiusTextBox.Show();
            SmallDiagonalTextBox.Show();
            LargeDiagonalTextBox.Show();
            LargeSideTextBox.Show();
            SmallSideTextBox.Show();
            ApothemTextBox.Show();
            SideTextBox.Show();
            SlantHeightTextBox.Show();
            PiTextBox.Show();
        }

        private void SquareAreaButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the square equation, sets the selection string to square area
            selectedequation = "squarearea";


            //inputs the picture of calculating the area of a square into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\square area equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Show();
            WidthTextBox.Hide();
            HeightTextBox.Hide();
            BaseTextBox.Hide();
            PerimeterTextBox.Hide();
            RadiusTextBox.Hide();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Hide();
        }

        private void RectangleAreaButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the rectangle equation, sets the selection string to rectangle area
            selectedequation = "rectanglearea";

            //inputs the picture of calculating the area of a rectangle into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\rectangle area equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
          
            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Show();
            HeightTextBox.Show();
            BaseTextBox.Hide();
            PerimeterTextBox.Hide();
            RadiusTextBox.Hide();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Hide();
        }

        private void TriangleAreaButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the triangle equation, sets the selection string to triangle area
            selectedequation = "trianglearea";

            //inputs the picture of calculating the area of a triange into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\triangle area equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Hide();
            HeightTextBox.Show();
            BaseTextBox.Show();
            PerimeterTextBox.Hide();
            RadiusTextBox.Hide();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Hide();
        }

        private void RhombusAreaButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the rhombus equation, sets the selection string to rhombus area
            selectedequation = "rhombusarea";

            //inputs the picture of calculating the area of a rhombus into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\rhombus area equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Hide();
            HeightTextBox.Hide();
            BaseTextBox.Hide();
            PerimeterTextBox.Hide();
            RadiusTextBox.Hide();
            SmallDiagonalTextBox.Show();
            LargeDiagonalTextBox.Show();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Hide();
        }

        private void TrapezoidAreaButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the trapezoid equation, sets the selection string to trapezoid area
            selectedequation = "trapezoidarea";

            //inputs the picture of calculating the area of a trapezoid into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\trapezoid area equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Hide();
            HeightTextBox.Show();
            BaseTextBox.Hide();
            PerimeterTextBox.Hide();
            RadiusTextBox.Hide();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Show();
            SmallSideTextBox.Show();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Hide();
        }

        private void PolygonAreaButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the polygon equation, sets the selection string to polygon area
            selectedequation = "polygonarea";

            //inputs the picture of calculating the area of a polygon into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\polygon area equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Hide();
            HeightTextBox.Hide();
            BaseTextBox.Hide();
            PerimeterTextBox.Show();
            RadiusTextBox.Hide();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Show();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Hide();
        }

        private void CircleAreaButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the circle equation, sets the selection string to circle area
            selectedequation = "circlearea";

            //inputs the picture of calculating the area of a circle into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\circle area equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Hide();
            HeightTextBox.Hide();
            BaseTextBox.Hide();
            PerimeterTextBox.Show();
            RadiusTextBox.Show();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Show();
            PiTextBox.Text = "3.14159";
        }

        private void ConeAreaButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the cone equation, sets the selection string to cone area
            selectedequation = "conearea";

            //inputs the picture of calculating the area of a cone into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\cone area equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Hide();
            HeightTextBox.Hide();
            BaseTextBox.Hide();
            PerimeterTextBox.Hide();
            RadiusTextBox.Show();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Show();
            PiTextBox.Show();
            PiTextBox.Text = "3.14159";

        }

        private void SphereAreaButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the sphere equation, sets the selection string to sphere area
            selectedequation = "spherearea";

            //inputs the picture of calculating the area of a sphere into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\sphere area equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Hide();
            HeightTextBox.Hide();
            BaseTextBox.Hide();
            PerimeterTextBox.Hide();
            RadiusTextBox.Show();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Show();
            PiTextBox.Text = "3.14159";

        }

        private void ParallelepipedVolumeButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the parallelpiped equation, sets the selection string to parallelepiped volume
            selectedequation = "parallelepipedvolume";

            //inputs the picture of calculating the volume of a parallelepiped into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\parallelepiped volume equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Show();
            WidthTextBox.Show();
            HeightTextBox.Show();
            BaseTextBox.Hide();
            PerimeterTextBox.Hide();
            RadiusTextBox.Hide();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Hide();
        }

        private void CubeVolumeButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the cube equation, sets the selection string to cube volume
            selectedequation = "cubevolume";

            //inputs the picture of calculating the volume of a cube into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\cube volume equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Hide();
            HeightTextBox.Hide();
            BaseTextBox.Hide();
            PerimeterTextBox.Hide();
            RadiusTextBox.Hide();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Show();
            SlantHeightTextBox.Hide();
            PiTextBox.Hide();
        }

        private void RegularPrismVolumeButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the regular prism equation, sets the selection string to regular prism volume
            selectedequation = "regularprismvolume";

            //inputs the picture of calculating the volume of a regular prism into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\regular prism volume equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Hide();
            HeightTextBox.Show();
            BaseTextBox.Show();
            PerimeterTextBox.Hide();
            RadiusTextBox.Hide();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Hide();
        }

        private void CylinderVolumeButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the cyliunder equation, sets the selection string to cylinder volume
            selectedequation = "cylindervolume";

            //inputs the picture of calculating the volume of a cylinder into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\cylinder volume equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Hide();
            HeightTextBox.Show();
            BaseTextBox.Hide();
            PerimeterTextBox.Hide();
            RadiusTextBox.Show();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Show();
            PiTextBox.Text = "3.14159";

        }

        private void ConeVolumeButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the cone equation, sets the selection string to cone volume
            selectedequation = "conevolume";

            //inputs the picture of calculating the volume of a cone into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\cone volume equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Hide();
            HeightTextBox.Show();
            BaseTextBox.Show();
            PerimeterTextBox.Hide();
            RadiusTextBox.Hide();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Hide();
        }

        private void SphereVolumeButton_Click(object sender, EventArgs e)
        {
            //upon user selecting the sphere equation, sets the selection string to sphere volume
            selectedequation = "spherevolume";

            //inputs the picture of calculating the volume of a sphere into the equation picture box and centers it
            EquationPictureBox.Image = Image.FromFile(@"C:\Users\My PC\Desktop\MS539\Areas and Volumes\sphere volume equation.png");
            EquationPictureBox.SizeMode = PictureBoxSizeMode.CenterImage;

            //displays only the needed inputs from the user and hides the other input boxes
            LenghtTextBox.Hide();
            WidthTextBox.Hide();
            HeightTextBox.Hide();
            BaseTextBox.Hide();
            PerimeterTextBox.Hide();
            RadiusTextBox.Show();
            SmallDiagonalTextBox.Hide();
            LargeDiagonalTextBox.Hide();
            LargeSideTextBox.Hide();
            SmallSideTextBox.Hide();
            ApothemTextBox.Hide();
            SideTextBox.Hide();
            SlantHeightTextBox.Hide();
            PiTextBox.Show();
            PiTextBox.Text = "3.14159";

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            if (selectedequation == "squarearea")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (LenghtTextBox.Text == "" || LenghtTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    length = decimal.Parse(LenghtTextBox.Text);
                    SquareAreaFormula obj_squareAreaFormula = new SquareAreaFormula();
                    area = obj_squareAreaFormula.Processchoice(length, area);
                    AreaTextBox.Text = area.ToString();
                    AreaTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "rectanglearea")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (WidthTextBox.Text == "" || WidthTextBox.Text == "0" || HeightTextBox.Text == "" || HeightTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    width = int.Parse(WidthTextBox.Text);
                    height = int.Parse(HeightTextBox.Text);
                    RectangleAreaFormula obj_rectangleAreaFormula = new RectangleAreaFormula();
                    area = obj_rectangleAreaFormula.Processchoice(width, height, area);
                    AreaTextBox.Text = area.ToString();
                    AreaTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "trianglearea")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (BaseTextBox.Text == "" || BaseTextBox.Text == "0" || HeightTextBox.Text == "" || HeightTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    baselength = int.Parse(BaseTextBox.Text);
                    height = int.Parse(HeightTextBox.Text);
                    TriangleAreaFormula obj_triangleAreaFormula = new TriangleAreaFormula();
                    area = obj_triangleAreaFormula.Processchoice(baselength, height, area);
                    AreaTextBox.Text = area.ToString();
                    AreaTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "rhombusarea")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (LargeDiagonalTextBox.Text == "" || LargeDiagonalTextBox.Text == "0" || SmallDiagonalTextBox.Text == "" || SmallDiagonalTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    smalldiagonal = int.Parse(SmallDiagonalTextBox.Text);
                    largediagonal = int.Parse(LargeDiagonalTextBox.Text);
                    RhombusAreaFormula obj_rhombusAreaFormula = new RhombusAreaFormula();
                    area = obj_rhombusAreaFormula.Processchoice(smalldiagonal, largediagonal, area);
                    AreaTextBox.Text = area.ToString();
                    AreaTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "trapezoidarea")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (LargeSideTextBox.Text == "" || LargeSideTextBox.Text == "0" || SmallSideTextBox.Text == "" || SmallSideTextBox.Text == "0" || HeightTextBox.Text == "" || HeightTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    smallside = decimal.Parse(SmallSideTextBox.Text);
                    largeside = decimal.Parse(LargeSideTextBox.Text);
                    TrapezoidAreaFormula obj_trapezoidAreaFormula = new TrapezoidAreaFormula();
                    area = obj_trapezoidAreaFormula.Processchoice(smallside, largeside, height, area);
                    AreaTextBox.Text = area.ToString();
                    AreaTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "polygonarea")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (PerimeterTextBox.Text == "" || PerimeterTextBox.Text == "0" || ApothemTextBox.Text == "" || ApothemTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    perimeter = decimal.Parse(PerimeterTextBox.Text);
                    apothem = decimal.Parse(ApothemTextBox.Text);
                    PolygonAreaFormula obj_polygonAreaFormula = new PolygonAreaFormula();
                    area = obj_polygonAreaFormula.Processchoice(perimeter, apothem, area);
                    AreaTextBox.Text = area.ToString();
                    AreaTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "circlearea")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (RadiusTextBox.Text == "" || RadiusTextBox.Text == "0" || PiTextBox.Text == "" || PiTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");

                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    radius = decimal.Parse(RadiusTextBox.Text);
                    CircleAreaFormula obj_circleAreaFormula = new CircleAreaFormula();
                    area = obj_circleAreaFormula.Processchoice(radius, area, pi);
                    AreaTextBox.Text = area.ToString();
                    AreaTextBox.TextAlign = HorizontalAlignment.Center;
                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "conearea")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (RadiusTextBox.Text == "" || RadiusTextBox.Text == "0" || SlantHeightTextBox.Text == "" || SlantHeightTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    radius = decimal.Parse(RadiusTextBox.Text);
                    slantheight = decimal.Parse(SlantHeightTextBox.Text);
                    ConeAreaFormula obj_coneAreaFormula = new ConeAreaFormula();
                    area = obj_coneAreaFormula.Processchoice(slantheight, radius, area, pi);
                    AreaTextBox.Text = area.ToString();
                    AreaTextBox.TextAlign = HorizontalAlignment.Center;

                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "spherearea")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (RadiusTextBox.Text == "" || RadiusTextBox.Text == "0" || PiTextBox.Text == "" || PiTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    radius = decimal.Parse(RadiusTextBox.Text);
                    SphereAreaFormula obj_sphereAreaFormula = new SphereAreaFormula();
                    area = obj_sphereAreaFormula.Processchoice(radius, area, pi);
                    AreaTextBox.Text = area.ToString();
                    AreaTextBox.TextAlign = HorizontalAlignment.Center;
                }

            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "parallelepipedvolume")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (LenghtTextBox.Text == "" || LenghtTextBox.Text == "0" || WidthTextBox.Text == "" || WidthTextBox.Text == "0" || HeightTextBox.Text == "" || HeightTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");

                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    length = decimal.Parse(LenghtTextBox.Text);
                    width = decimal.Parse(WidthTextBox.Text);
                    height = decimal.Parse(HeightTextBox.Text);
                    ParallepipedVolumeFormula obj_parallepipedVolumeFormula = new ParallepipedVolumeFormula();
                    volume = obj_parallepipedVolumeFormula.Processchoice(length, height, width, volume);
                    VolumeTextBox.Text = volume.ToString();
                    VolumeTextBox.TextAlign = HorizontalAlignment.Center;

                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "cubevolume")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (SideTextBox.Text == "" || SideTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    side = decimal.Parse(SideTextBox.Text);
                    CubeVolumeFormula obj_cubeVolumeFormula = new CubeVolumeFormula();
                    volume = obj_cubeVolumeFormula.Processchoice(side, volume);
                    VolumeTextBox.Text = volume.ToString();
                    VolumeTextBox.TextAlign = HorizontalAlignment.Center;

                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "regularprismvolume")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (BaseTextBox.Text == "" || BaseTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    baselength = decimal.Parse(BaseTextBox.Text);
                    height = decimal.Parse(HeightTextBox.Text);
                    RegularPrismVolumeFormula obj_regularPrismVolumeFormula = new RegularPrismVolumeFormula();
                    volume = obj_regularPrismVolumeFormula.Processchoice(baselength, height, volume);
                    VolumeTextBox.Text = volume.ToString();
                    VolumeTextBox.TextAlign = HorizontalAlignment.Center;

                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "cylindervolume")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (RadiusTextBox.Text == "" || RadiusTextBox.Text == "0" || PiTextBox.Text == "" || PiTextBox.Text == "0" || HeightTextBox.Text == "" || HeightTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    radius = decimal.Parse(RadiusTextBox.Text);
                    height = decimal.Parse(HeightTextBox.Text);
                    CylinderVolumeFormula obj_cylinderVolumeFormula = new CylinderVolumeFormula();
                    volume = obj_cylinderVolumeFormula.Processchoice(radius, pi, height, volume);
                    VolumeTextBox.Text = volume.ToString();
                    VolumeTextBox.TextAlign = HorizontalAlignment.Center;

                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "conevolume")
            {
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (BaseTextBox.Text == "" || BaseTextBox.Text == "0" || HeightTextBox.Text == "" || HeightTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    baselength = decimal.Parse(BaseTextBox.Text);
                    height = decimal.Parse(HeightTextBox.Text);
                    ConeVolumeFormula obj_coneVolumeFormula = new ConeVolumeFormula();
                    volume = obj_coneVolumeFormula.Processchoice(baselength, height, volume);
                    VolumeTextBox.Text = volume.ToString();
                    VolumeTextBox.TextAlign = HorizontalAlignment.Center;

                }
            }
            //if statements that when you user executes the calculate button checks to see which equation was selected to run
            else if (selectedequation == "spherevolume")
            { 
                //checks to make sure the variable boxes for the given equations are not blank or have a value of 0
                if (RadiusTextBox.Text == "" || RadiusTextBox.Text == "0" || PiTextBox.Text == "" || PiTextBox.Text == "0")
                {
                    //notifies user that they are missing or using incorrect variables for the equation
                    MessageBox.Show("You're either missing variables or using 0's.");
                }
                else
                {
                    //takes the user inputted variables and pushes the data over to the prescribed DLL program to run the equation math.
                    //following the DLL work, the data comes back and is displayed and centered in the solution box at the bottom of the screen.
                    radius = decimal.Parse(RadiusTextBox.Text);
                    SphereVolumeFormula obj_sphereVolumeFormula = new SphereVolumeFormula();
                    volume = obj_sphereVolumeFormula.Processchoice(radius, pi, volume);
                    VolumeTextBox.Text = volume.ToString();
                    VolumeTextBox.TextAlign = HorizontalAlignment.Center;

                }
            }

        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            //When the user clicks on the clear button, it removes the equation selection as well as re-displays all the available variables and clears their data
            EquationPictureBox.Image = null;
            LenghtTextBox.Show();
            WidthTextBox.Show();
            HeightTextBox.Show();
            BaseTextBox.Show();
            PerimeterTextBox.Show();
            RadiusTextBox.Show();
            SmallDiagonalTextBox.Show();
            LargeDiagonalTextBox.Show();
            LargeSideTextBox.Show();
            SmallSideTextBox.Show();
            ApothemTextBox.Show();
            SideTextBox.Show();
            SlantHeightTextBox.Show();
            PiTextBox.Show();
            LenghtTextBox.Clear();
            WidthTextBox.Clear(); 
            HeightTextBox.Clear();
            BaseTextBox.Clear();
            PerimeterTextBox.Clear();
            RadiusTextBox.Clear();
            SmallDiagonalTextBox.Clear();
            LargeDiagonalTextBox.Clear();
            LargeSideTextBox.Clear();
            SmallSideTextBox.Clear();
            ApothemTextBox.Clear();
            SideTextBox.Clear();
            SlantHeightTextBox.Clear();
            PiTextBox.Clear();
            AreaTextBox.Clear();
            VolumeTextBox.Clear();

        }
    }
}
