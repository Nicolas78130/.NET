using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void BtnJ1_Click(object sender, EventArgs e)
    {
        LabelAvoirNom.Text = TxtNom.Text;
        if (LabelAvoirNom.Text == "")
        {
            labelNom.Text = "Write a name";
        }
        else
        {
            labelNom.Text = "Player 1";
            BtnJ1.Enabled = false;
            BtnJ2.Enabled = true;
        }
    }

    protected void BtnJ2_Click(object sender, EventArgs e)
    {
        LabelAvoirNom2.Text = TxtNom2.Text;
        if (LabelAvoirNom2.Text == "")
        {
            LabelNom2.Text = "Write a name";
        }
        else if (LabelAvoirNom.Text == LabelAvoirNom2.Text)
        {
            LabelNom2.Text = "Write another name";
        }
        else
        {
            LabelNom2.Text = "Player 2";
            LabelCestTour.Visible = true;
            int Joueur = 1;
            TourJoueur.Text = Joueur.ToString();
            Button1.Enabled = true;
            Button2.Enabled = true;
            Button3.Enabled = true;
            Button4.Enabled = true;
            Button5.Enabled = true;
            Button6.Enabled = true;
            Button7.Enabled = true;
            ButtonRecommencer.Enabled = true;
            ButtonRecommencer.Visible = true;
            labelNom.Enabled = false;
            LabelNom2.Enabled = false;
            BtnJ2.Enabled = false;
            LabelScore.Visible = true;
            LabelScore2.Visible = true;
            LabelScoreJ1.Visible = true;
            LabelScoreJ2.Visible = true;
            LabelScore.Visible = true;
            LabelScore2.Visible = true;
            LabelSlash.Visible = true;
            TourJoueur.Visible = true;
            LabelCompteCoup.Text = "0";
            List<List<Image>> PlateauJeu = new List<List<Image>>();
            PlateauJeu.Add(new List<Image>
        {
            Image1,
            Image2,
            Image3,
            Image4,
            Image5,
            Image6,
            Image7,
        });
            PlateauJeu.Add(new List<Image>
        {
            Image8,
            Image9,
            Image10,
            Image11,
            Image12,
            Image13,
            Image14,
        });
            PlateauJeu.Add(new List<Image>
        {
            Image15,
            Image16,
            Image17,
            Image18,
            Image19,
            Image20,
            Image21,
        });
            PlateauJeu.Add(new List<Image>
        {
            Image22,
            Image23,
            Image24,
            Image25,
            Image26,
            Image27,
            Image28,
        });
            PlateauJeu.Add(new List<Image>
        {
            Image29,
            Image30,
            Image31,
            Image32,
            Image33,
            Image34,
            Image35,
        });
            PlateauJeu.Add(new List<Image>
        {
            Image36,
            Image37,
            Image38,
            Image39,
            Image40,
            Image41,
            Image42,
        });
            Image1.ImageUrl = ImageJ0.ImageUrl;
            Image2.ImageUrl = ImageJ0.ImageUrl;
            Image3.ImageUrl = ImageJ0.ImageUrl;
            Image4.ImageUrl = ImageJ0.ImageUrl;
            Image5.ImageUrl = ImageJ0.ImageUrl;
            Image6.ImageUrl = ImageJ0.ImageUrl;
            Image7.ImageUrl = ImageJ0.ImageUrl;
            Image8.ImageUrl = ImageJ0.ImageUrl;
            Image9.ImageUrl = ImageJ0.ImageUrl;
            Image10.ImageUrl = ImageJ0.ImageUrl;
            Image11.ImageUrl = ImageJ0.ImageUrl;
            Image12.ImageUrl = ImageJ0.ImageUrl;
            Image13.ImageUrl = ImageJ0.ImageUrl;
            Image14.ImageUrl = ImageJ0.ImageUrl;
            Image15.ImageUrl = ImageJ0.ImageUrl;
            Image16.ImageUrl = ImageJ0.ImageUrl;
            Image17.ImageUrl = ImageJ0.ImageUrl;
            Image18.ImageUrl = ImageJ0.ImageUrl;
            Image19.ImageUrl = ImageJ0.ImageUrl;
            Image20.ImageUrl = ImageJ0.ImageUrl;
            Image21.ImageUrl = ImageJ0.ImageUrl;
            Image22.ImageUrl = ImageJ0.ImageUrl;
            Image23.ImageUrl = ImageJ0.ImageUrl;
            Image24.ImageUrl = ImageJ0.ImageUrl;
            Image25.ImageUrl = ImageJ0.ImageUrl;
            Image26.ImageUrl = ImageJ0.ImageUrl;
            Image27.ImageUrl = ImageJ0.ImageUrl;
            Image28.ImageUrl = ImageJ0.ImageUrl;
            Image29.ImageUrl = ImageJ0.ImageUrl;
            Image30.ImageUrl = ImageJ0.ImageUrl;
            Image31.ImageUrl = ImageJ0.ImageUrl;
            Image32.ImageUrl = ImageJ0.ImageUrl;
            Image33.ImageUrl = ImageJ0.ImageUrl;
            Image34.ImageUrl = ImageJ0.ImageUrl;
            Image35.ImageUrl = ImageJ0.ImageUrl;
            Image36.ImageUrl = ImageJ0.ImageUrl;
            Image37.ImageUrl = ImageJ0.ImageUrl;
            Image38.ImageUrl = ImageJ0.ImageUrl;
            Image39.ImageUrl = ImageJ0.ImageUrl;
            Image40.ImageUrl = ImageJ0.ImageUrl;
            Image41.ImageUrl = ImageJ0.ImageUrl;
            Image42.ImageUrl = ImageJ0.ImageUrl;
        }
    }
    protected void NumJoueur()
    {
        int Joueur;
        int.TryParse(TourJoueur.Text, out Joueur);
        Joueur = Joueur % 2 + 1;
        TourJoueur.Text = Joueur.ToString();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        NumJoueur();
        int x = 0;
        Remplissage(x);
        Winner();
        int j;
        int.TryParse(LabelCompteCoup.Text, out j);
        j = j + 1;
        LabelCompteCoup.Text = j.ToString();
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        NumJoueur();
        int x = 1;
        Remplissage(x);
        Winner();
        int j;
        int.TryParse(LabelCompteCoup.Text, out j);
        j = j + 1;
        LabelCompteCoup.Text = j.ToString();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        NumJoueur();
        int x = 2;
        Remplissage(x);
        Winner();
        int j;
        int.TryParse(LabelCompteCoup.Text, out j);
        j = j + 1;
        LabelCompteCoup.Text = j.ToString();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        NumJoueur();
        int x = 3;
        Remplissage(x);
        Winner();
        int j;
        int.TryParse(LabelCompteCoup.Text, out j);
        j = j + 1;
        LabelCompteCoup.Text = j.ToString();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        NumJoueur();
        int x = 4;
        Remplissage(x);
        Winner();
        int j;
        int.TryParse(LabelCompteCoup.Text, out j);
        j = j + 1;
        LabelCompteCoup.Text = j.ToString();
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        NumJoueur();
        int x = 5;
        Remplissage(x);
        Winner();
        int j;
        int.TryParse(LabelCompteCoup.Text, out j);
        j = j + 1;
        LabelCompteCoup.Text = j.ToString();
    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        NumJoueur();
        int x = 6;
        Remplissage(x);
        Winner();
        int j;
        int.TryParse(LabelCompteCoup.Text, out j);
        j = j + 1;
        LabelCompteCoup.Text = j.ToString();
    }
    void Remplissage(int x)
    {
        List<List<Image>> PlateauJeu = new List<List<Image>>();
        PlateauJeu.Add(new List<Image>
        {
            Image1,
            Image2,
            Image3,
            Image4,
            Image5,
            Image6,
            Image7,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image8,
            Image9,
            Image10,
            Image11,
            Image12,
            Image13,
            Image14,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image15,
            Image16,
            Image17,
            Image18,
            Image19,
            Image20,
            Image21,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image22,
            Image23,
            Image24,
            Image25,
            Image26,
            Image27,
            Image28,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image29,
            Image30,
            Image31,
            Image32,
            Image33,
            Image34,
            Image35,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image36,
            Image37,
            Image38,
            Image39,
            Image40,
            Image41,
            Image42,
        });
        switch (x)
        {
            case 0:
                {
                    for (int i = 5; i >= 0; i--)
                    {
                        if (PlateauJeu[i][0].ImageUrl == ImageJ0.ImageUrl)
                        {
                            int y;
                            int.TryParse(TourJoueur.Text, out y);
                            if (i == 0)
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][0].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                    Button1.Enabled = false;
                                }
                                else
                                {
                                    PlateauJeu[i][0].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                    Button1.Enabled = false;
                                }
                            }
                            else
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][0].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                }
                                else
                                {
                                    PlateauJeu[i][0].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                }
                            }
                        }
                    }
                }
                break;
            case 1:
                {
                    for (int i = 5; i >= 0; i--)
                    {
                        if (PlateauJeu[i][1].ImageUrl == ImageJ0.ImageUrl)
                        {
                            int y;
                            int.TryParse(TourJoueur.Text, out y);
                            if (i == 0)
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][1].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                    Button2.Enabled = false;
                                }
                                else
                                {
                                    PlateauJeu[i][1].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                    Button2.Enabled = false;
                                }
                            }
                            else
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][1].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                }
                                else
                                {
                                    PlateauJeu[i][1].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                }
                            }
                        }
                    }
                }
                break;
            case 2:
                {
                    for (int i = 5; i >= 0; i--)
                    {
                        if (PlateauJeu[i][2].ImageUrl == ImageJ0.ImageUrl)
                        {
                            int y;
                            int.TryParse(TourJoueur.Text, out y);
                            if (i == 0)
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][2].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                    Button3.Enabled = false;
                                }
                                else
                                {
                                    PlateauJeu[i][2].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                    Button3.Enabled = false;
                                }
                            }
                            else
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][2].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                }
                                else
                                {
                                    PlateauJeu[i][2].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                }
                            }
                        }
                    }
                }
                break;
            case 3:
                {
                    for (int i = 5; i >= 0; i--)
                    {
                        if (PlateauJeu[i][3].ImageUrl == ImageJ0.ImageUrl)
                        {
                            int y;
                            int.TryParse(TourJoueur.Text, out y);
                            if (i == 0)
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][3].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                    Button4.Enabled = false;
                                }
                                else
                                {
                                    PlateauJeu[i][3].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                    Button4.Enabled = false;
                                }
                            }
                            else
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][3].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                }
                                else
                                {
                                    PlateauJeu[i][3].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                }
                            }
                        }
                    }
                }
                break;
            case 4:
                {
                    for (int i = 5; i >= 0; i--)
                    {
                        if (PlateauJeu[i][4].ImageUrl == ImageJ0.ImageUrl)
                        {
                            int y;
                            int.TryParse(TourJoueur.Text, out y);
                            if (i == 0)
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][4].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                    Button5.Enabled = false;
                                }
                                else
                                {
                                    PlateauJeu[i][4].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                    Button5.Enabled = false;
                                }
                            }
                            else
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][4].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                }
                                else
                                {
                                    PlateauJeu[i][4].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                }
                            }
                        }
                    }
                }
                break;
            case 5:
                {
                    for (int i = 5; i >= 0; i--)
                    {
                        if (PlateauJeu[i][5].ImageUrl == ImageJ0.ImageUrl)
                        {
                            int y;
                            int.TryParse(TourJoueur.Text, out y);
                            if (i == 0)
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][5].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                    Button6.Enabled = false;
                                }
                                else
                                {
                                    PlateauJeu[i][5].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                    Button6.Enabled = false;
                                }
                            }
                            else
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][5].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                }
                                else
                                {
                                    PlateauJeu[i][5].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                }
                            }
                        }
                    }
                }
                break;
            case 6:
                {
                    for (int i = 5; i >= 0; i--)
                    {
                        if (PlateauJeu[i][6].ImageUrl == ImageJ0.ImageUrl)
                        {
                            int y;
                            int.TryParse(TourJoueur.Text, out y);
                            if (i == 0)
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][6].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                    Button7.Enabled = false;
                                }
                                else
                                {
                                    PlateauJeu[i][6].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                    Button7.Enabled = false;
                                }
                            }
                            else
                            {
                                if (y == 1)
                                {
                                    PlateauJeu[i][6].ImageUrl = ImageJ1.ImageUrl;
                                    i = 0;
                                }
                                else
                                {
                                    PlateauJeu[i][6].ImageUrl = ImageJ2.ImageUrl;
                                    i = 0;
                                }
                            }
                        }
                    }
                }
                break;
        }
  }
    void Winner()
    {
        List<List<Image>> PlateauJeu = new List<List<Image>>();
        PlateauJeu.Add(new List<Image>
        {
            Image1,
            Image2,
            Image3,
            Image4,
            Image5,
            Image6,
            Image7,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image8,
            Image9,
            Image10,
            Image11,
            Image12,
            Image13,
            Image14,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image15,
            Image16,
            Image17,
            Image18,
            Image19,
            Image20,
            Image21,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image22,
            Image23,
            Image24,
            Image25,
            Image26,
            Image27,
            Image28,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image29,
            Image30,
            Image31,
            Image32,
            Image33,
            Image34,
            Image35,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image36,
            Image37,
            Image38,
            Image39,
            Image40,
            Image41,
            Image42,
        });
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if(PlateauJeu[i][j].ImageUrl == ImageJ1.ImageUrl && PlateauJeu[i][j + 1].ImageUrl == ImageJ1.ImageUrl && PlateauJeu[i][j + 2].ImageUrl == ImageJ1.ImageUrl && PlateauJeu[i][j + 3].ImageUrl == ImageJ1.ImageUrl)
                {
                    ThisIsWinner.Visible = true;
                    ThisIsWinner.Text = LabelAvoirNom2.Text + " wins !";
                    i = 6;
                    j = 4;
                    Button1.Enabled = false;
                    Button2.Enabled = false;
                    Button3.Enabled = false;
                    Button4.Enabled = false;
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button7.Enabled = false;
                    TourJoueur.Visible = false;
                    LabelCestTour.Visible = false;
                    LabelRejouer.Visible = true;
                    ButtonRejouer.Visible = true;
                    ButtonRejouer.Enabled = true;
                    ButtonPasRejouer.Visible = true;
                    ButtonPasRejouer.Enabled = true;
                    ButtonRecommencer.Enabled = false;
                    ButtonRecommencer.Visible = false;
                    int Score;
                    int.TryParse(LabelScoreJ2.Text, out Score);
                    Score = Score + 1;
                    LabelScoreJ2.Text = Score.ToString();
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LastConnectionString"].ConnectionString);
                        conn.Open();
                        string insertQuery = "Insert into Classement (Names,Scores) values (@Name, @Score)";
                        SqlCommand com = new SqlCommand(insertQuery, conn);
                        com.Parameters.AddWithValue("@Name", TxtNom2.Text);
                        com.Parameters.AddWithValue("@Score", LabelCompteCoup.Text);
                        com.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (PlateauJeu[i][j].ImageUrl == ImageJ2.ImageUrl && PlateauJeu[i][j + 1].ImageUrl == ImageJ2.ImageUrl && PlateauJeu[i][j + 2].ImageUrl == ImageJ2.ImageUrl && PlateauJeu[i][j + 3].ImageUrl == ImageJ2.ImageUrl)
                {
                    ThisIsWinner.Visible = true;
                    ThisIsWinner.Text = LabelAvoirNom.Text + " wins !";
                    i = 6;
                    j = 4;
                    Button1.Enabled = false;
                    Button2.Enabled = false;
                    Button3.Enabled = false;
                    Button4.Enabled = false;
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button7.Enabled = false;
                    TourJoueur.Visible = false;
                    LabelCestTour.Visible = false;
                    LabelRejouer.Visible = true;
                    ButtonRejouer.Visible = true;
                    ButtonRejouer.Enabled = true;
                    ButtonPasRejouer.Visible = true;
                    ButtonPasRejouer.Enabled = true;
                    ButtonRecommencer.Enabled = false;
                    ButtonRecommencer.Visible = false;
                    int Score;
                    int.TryParse(LabelScoreJ1.Text, out Score);
                    Score = Score + 1;
                    LabelScoreJ1.Text = Score.ToString();
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LastConnectionString"].ConnectionString);
                        conn.Open();
                        string insertQuery = "Insert into Classement (Names,Scores) values (@Name, @Score)";
                        SqlCommand com = new SqlCommand(insertQuery, conn);
                        com.Parameters.AddWithValue("@Name", TxtNom.Text);
                        com.Parameters.AddWithValue("@Score", LabelCompteCoup.Text);
                        com.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 7; j++)
            {
                if (PlateauJeu[i][j].ImageUrl == ImageJ1.ImageUrl && PlateauJeu[i + 1][j].ImageUrl == ImageJ1.ImageUrl && PlateauJeu[i + 2][j].ImageUrl == ImageJ1.ImageUrl && PlateauJeu[i + 3][j].ImageUrl == ImageJ1.ImageUrl)
                {
                    ThisIsWinner.Visible = true;
                    ThisIsWinner.Text = LabelAvoirNom2.Text + " wins !";
                    i = 3;
                    j = 7;
                    Button1.Enabled = false;
                    Button2.Enabled = false;
                    Button3.Enabled = false;
                    Button4.Enabled = false;
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button7.Enabled = false;
                    TourJoueur.Visible = false;
                    LabelCestTour.Visible = false;
                    LabelRejouer.Visible = true;
                    ButtonRejouer.Visible = true;
                    ButtonRejouer.Enabled = true;
                    ButtonPasRejouer.Visible = true;
                    ButtonPasRejouer.Enabled = true;
                    ButtonRecommencer.Enabled = false;
                    ButtonRecommencer.Visible = false;
                    int Score;
                    int.TryParse(LabelScoreJ2.Text, out Score);
                    Score = Score + 1;
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ScoreConnectionString"].ConnectionString);
                        conn.Open();
                        string insertQuery = "Insert into Table (Names,Scores) values (@Name, @Score)";
                        SqlCommand com = new SqlCommand(insertQuery, conn);
                        com.Parameters.AddWithValue("@Name", TxtNom2.Text);
                        int b;
                        int.TryParse(LabelCompteCoup.Text, out b);
                        com.Parameters.AddWithValue("@Score", b);
                        com.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception Ex)
                    {

                    }
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LastConnectionString"].ConnectionString);
                        conn.Open();
                        string insertQuery = "Insert into Classement (Names,Scores) values (@Name, @Score)";
                        SqlCommand com = new SqlCommand(insertQuery, conn);
                        com.Parameters.AddWithValue("@Name", TxtNom2.Text);
                        com.Parameters.AddWithValue("@Score", LabelCompteCoup.Text);
                        com.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (PlateauJeu[i][j].ImageUrl == ImageJ2.ImageUrl && PlateauJeu[i + 1][j].ImageUrl == ImageJ2.ImageUrl && PlateauJeu[i + 2][j].ImageUrl == ImageJ2.ImageUrl && PlateauJeu[i + 3][j].ImageUrl == ImageJ2.ImageUrl)
                {
                    ThisIsWinner.Visible = true;
                    ThisIsWinner.Text = LabelAvoirNom.Text + " wins !";
                    i = 3;
                    j = 7;
                    Button1.Enabled = false;
                    Button2.Enabled = false;
                    Button3.Enabled = false;
                    Button4.Enabled = false;
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button7.Enabled = false;
                    TourJoueur.Visible = false;
                    LabelCestTour.Visible = false;
                    LabelRejouer.Visible = true;
                    ButtonRejouer.Visible = true;
                    ButtonRejouer.Enabled = true;
                    ButtonPasRejouer.Visible = true;
                    ButtonPasRejouer.Enabled = true;
                    ButtonRecommencer.Enabled = false;
                    ButtonRecommencer.Visible = false;
                    int Score;
                    int.TryParse(LabelScoreJ1.Text, out Score);
                    Score = Score + 1;
                    LabelScoreJ1.Text = Score.ToString();
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LastConnectionString"].ConnectionString);
                        conn.Open();
                        string insertQuery = "Insert into Classement (Names,Scores) values (@Name, @Score)";
                        SqlCommand com = new SqlCommand(insertQuery, conn);
                        com.Parameters.AddWithValue("@Name", TxtNom.Text);
                        com.Parameters.AddWithValue("@Score", LabelCompteCoup.Text);
                        com.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {

                    }

                }
            }
        }
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (PlateauJeu[i][j].ImageUrl == ImageJ1.ImageUrl && PlateauJeu[i + 1][j + 1].ImageUrl == ImageJ1.ImageUrl && PlateauJeu[i + 2][j + 2].ImageUrl == ImageJ1.ImageUrl && PlateauJeu[i + 3][j + 3].ImageUrl == ImageJ1.ImageUrl)
                {
                    ThisIsWinner.Visible = true;
                    ThisIsWinner.Text = LabelAvoirNom2.Text + " wins !";
                    i = 3;
                    j = 4;
                    Button1.Enabled = false;
                    Button2.Enabled = false;
                    Button3.Enabled = false;
                    Button4.Enabled = false;
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button7.Enabled = false;
                    TourJoueur.Visible = false;
                    LabelCestTour.Visible = false;
                    LabelRejouer.Visible = true;
                    ButtonRejouer.Visible = true;
                    ButtonRejouer.Enabled = true;
                    ButtonPasRejouer.Visible = true;
                    ButtonPasRejouer.Enabled = true;
                    ButtonRecommencer.Enabled = false;
                    ButtonRecommencer.Visible = false;
                    int Score;
                    int.TryParse(LabelScoreJ2.Text, out Score);
                    Score = Score + 1;
                    LabelScoreJ2.Text = Score.ToString();
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LastConnectionString"].ConnectionString);
                        conn.Open();
                        string insertQuery = "Insert into Classement (Names,Scores) values (@Name, @Score)";
                        SqlCommand com = new SqlCommand(insertQuery, conn);
                        com.Parameters.AddWithValue("@Name", TxtNom2.Text);
                        com.Parameters.AddWithValue("@Score", LabelCompteCoup.Text);
                        com.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (PlateauJeu[i][j].ImageUrl == ImageJ2.ImageUrl && PlateauJeu[i + 1][j + 1].ImageUrl == ImageJ2.ImageUrl && PlateauJeu[i + 2][j + 2].ImageUrl == ImageJ2.ImageUrl && PlateauJeu[i + 3][j + 3].ImageUrl == ImageJ2.ImageUrl)
                {
                    ThisIsWinner.Visible = true;
                    ThisIsWinner.Text = LabelAvoirNom.Text + " wins !";
                    i = 3;
                    j = 4;
                    Button1.Enabled = false;
                    Button2.Enabled = false;
                    Button3.Enabled = false;
                    Button4.Enabled = false;
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button7.Enabled = false;
                    TourJoueur.Visible = false;
                    LabelCestTour.Visible = false;
                    LabelRejouer.Visible = true;
                    ButtonRejouer.Visible = true;
                    ButtonRejouer.Enabled = true;
                    ButtonPasRejouer.Visible = true;
                    ButtonPasRejouer.Enabled = true;
                    ButtonRecommencer.Enabled = false;
                    ButtonRecommencer.Visible = false;
                    int Score;
                    int.TryParse(LabelScoreJ1.Text, out Score);
                    Score = Score + 1;
                    LabelScoreJ1.Text = Score.ToString();
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LastConnectionString"].ConnectionString);
                        conn.Open();
                        string insertQuery = "Insert into Classement (Names,Scores) values (@Name, @Score)";
                        SqlCommand com = new SqlCommand(insertQuery, conn);
                        com.Parameters.AddWithValue("@Name", TxtNom.Text);
                        com.Parameters.AddWithValue("@Score", LabelCompteCoup.Text);
                        com.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
        for (int i = 3; i < 6; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (PlateauJeu[i][j].ImageUrl == ImageJ1.ImageUrl && PlateauJeu[i - 1][j + 1].ImageUrl == ImageJ1.ImageUrl && PlateauJeu[i - 2][j + 2].ImageUrl == ImageJ1.ImageUrl && PlateauJeu[i - 3][j + 3].ImageUrl == ImageJ1.ImageUrl)
                {
                    ThisIsWinner.Visible = true;
                    ThisIsWinner.Text = LabelAvoirNom2.Text + " wins !";
                    i = 6;
                    j = 4;
                    Button1.Enabled = false;
                    Button2.Enabled = false;
                    Button3.Enabled = false;
                    Button4.Enabled = false;
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button7.Enabled = false;
                    TourJoueur.Visible = false;
                    LabelCestTour.Visible = false;
                    LabelRejouer.Visible = true;
                    ButtonRejouer.Visible = true;
                    ButtonRejouer.Enabled = true;
                    ButtonPasRejouer.Visible = true;
                    ButtonPasRejouer.Enabled = true;
                    ButtonRecommencer.Enabled = false;
                    ButtonRecommencer.Visible = false;
                    int Score;
                    int.TryParse(LabelScoreJ2.Text, out Score);
                    Score = Score + 1;
                    LabelScoreJ2.Text = Score.ToString();
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LastConnectionString"].ConnectionString);
                        conn.Open();
                        string insertQuery = "Insert into Classement (Names,Scores) values (@Name, @Score)";
                        SqlCommand com = new SqlCommand(insertQuery, conn);
                        com.Parameters.AddWithValue("@Name", TxtNom2.Text);
                        com.Parameters.AddWithValue("@Score", LabelCompteCoup.Text);
                        com.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else if (PlateauJeu[i][j].ImageUrl == ImageJ2.ImageUrl && PlateauJeu[i - 1][j + 1].ImageUrl == ImageJ2.ImageUrl && PlateauJeu[i - 2][j + 2].ImageUrl == ImageJ2.ImageUrl && PlateauJeu[i - 3][j + 3].ImageUrl == ImageJ2.ImageUrl)
                {
                    ThisIsWinner.Visible = true;
                    ThisIsWinner.Text = LabelAvoirNom.Text + " wins !";
                    i = 6;
                    j = 4;
                    Button1.Enabled = false;
                    Button2.Enabled = false;
                    Button3.Enabled = false;
                    Button4.Enabled = false;
                    Button5.Enabled = false;
                    Button6.Enabled = false;
                    Button7.Enabled = false;
                    TourJoueur.Visible = false;
                    LabelCestTour.Visible = false;
                    LabelRejouer.Visible = true;
                    ButtonRejouer.Visible = true;
                    ButtonRejouer.Enabled = true;
                    ButtonPasRejouer.Visible = true;
                    ButtonPasRejouer.Enabled = true;
                    ButtonRecommencer.Enabled = false;
                    ButtonRecommencer.Visible = false;
                    int Score;
                    int.TryParse(LabelScoreJ1.Text, out Score);
                    Score = Score + 1;
                    LabelScoreJ1.Text = Score.ToString();
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["LastConnectionString"].ConnectionString);
                        conn.Open();
                        string insertQuery = "Insert into Classement (Names,Scores) values (@Name, @Score)";
                        SqlCommand com = new SqlCommand(insertQuery, conn);
                        com.Parameters.AddWithValue("@Name", TxtNom.Text);
                        com.Parameters.AddWithValue("@Score", LabelCompteCoup.Text);
                        com.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }

    protected void ButtonRejouer_Click(object sender, EventArgs e)
    {
        ButtonRejouer.Visible = false;
        LabelRejouer.Visible = false;
        ButtonRejouer.Enabled = false;
        Label1.Visible = true;
        ButtonChangeJoueur.Visible = true;
        ButtonChangeJoueur.Enabled = true;
        ButtonPasChangeJoueur.Visible = true;
        ButtonPasChangeJoueur.Enabled = true;
        ButtonPasRejouer.Enabled = false;
        ButtonPasRejouer.Visible = false;
    }

    protected void ButtonChangeJoueur_Click(object sender, EventArgs e)
    {
        LabelScoreJ1.Text = "0";
        LabelScoreJ2.Text = "0";
        BtnJ1.Enabled = true;
        ThisIsWinner.Visible = false;
        LabelRejouer.Visible = false;
        ButtonRejouer.Visible = false;
        ButtonRejouer.Enabled = false;
        ButtonPasRejouer.Visible = false;
        ButtonPasRejouer.Visible = false;
        ButtonChangeJoueur.Visible = false;
        ButtonChangeJoueur.Enabled = false;
        Label1.Visible = false;
        ButtonPasChangeJoueur.Visible = false;
        ButtonPasChangeJoueur.Enabled = false;
    }

    protected void ButtonPasRejouer_Click(object sender, EventArgs e)
    {
        LabelCompteCoup.Text = "0";
        LabelScoreJ1.Text = "0";
        LabelScoreJ1.Text = "0";
        ButtonPasRejouer.Enabled = false;
        ButtonPasRejouer.Visible = false;
        ButtonRejouer.Visible = false;
        ButtonRejouer.Enabled = false;
        LabelRejouer.Visible = false;
        ButtonRecommencer.Visible = true;
        ButtonRecommencer.Enabled = true;
    }

    protected void ButtonRecommencer_Click(object sender, EventArgs e)
    {
        LabelCestTour.Visible = false;
        TourJoueur.Visible = false;
        Label1.Visible = true;
        ButtonRecommencer.Visible = false;
        ButtonRecommencer.Enabled = false;
        ButtonChangeJoueur.Enabled = true;
        ButtonChangeJoueur.Visible = true;
        ButtonPasChangeJoueur.Visible = true;
        ButtonPasChangeJoueur.Enabled = true;
        ThisIsWinner.Visible = false;
     }

    protected void ButtonPasChangeJoueur_Click(object sender, EventArgs e)
    {
        ButtonPasChangeJoueur.Visible = false;
        ButtonPasChangeJoueur.Enabled = false;
        LabelCestTour.Visible = true;
        int Joueur = 1;
        TourJoueur.Text = Joueur.ToString();
        Button1.Enabled = true;
        Button2.Enabled = true;
        Button3.Enabled = true;
        Button4.Enabled = true;
        Button5.Enabled = true;
        Button6.Enabled = true;
        Button7.Enabled = true;
        ButtonRecommencer.Enabled = true;
        ButtonRecommencer.Visible = true;
        ThisIsWinner.Visible = false;
        Label1.Visible = false;
        ButtonChangeJoueur.Visible = false;
        ButtonChangeJoueur.Enabled = false;
        labelNom.Enabled = false;
        LabelNom2.Enabled = false;
        BtnJ2.Enabled = false;
        TourJoueur.Visible = true;
        List<List<Image>> PlateauJeu = new List<List<Image>>();
        PlateauJeu.Add(new List<Image>
        {
            Image1,
            Image2,
            Image3,
            Image4,
            Image5,
            Image6,
            Image7,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image8,
            Image9,
            Image10,
            Image11,
            Image12,
            Image13,
            Image14,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image15,
            Image16,
            Image17,
            Image18,
            Image19,
            Image20,
            Image21,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image22,
            Image23,
            Image24,
            Image25,
            Image26,
            Image27,
            Image28,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image29,
            Image30,
            Image31,
            Image32,
            Image33,
            Image34,
            Image35,
        });
        PlateauJeu.Add(new List<Image>
        {
            Image36,
            Image37,
            Image38,
            Image39,
            Image40,
            Image41,
            Image42,
        });
        Image1.ImageUrl = ImageJ0.ImageUrl;
        Image2.ImageUrl = ImageJ0.ImageUrl;
        Image3.ImageUrl = ImageJ0.ImageUrl;
        Image4.ImageUrl = ImageJ0.ImageUrl;
        Image5.ImageUrl = ImageJ0.ImageUrl;
        Image6.ImageUrl = ImageJ0.ImageUrl;
        Image7.ImageUrl = ImageJ0.ImageUrl;
        Image8.ImageUrl = ImageJ0.ImageUrl;
        Image9.ImageUrl = ImageJ0.ImageUrl;
        Image10.ImageUrl = ImageJ0.ImageUrl;
        Image11.ImageUrl = ImageJ0.ImageUrl;
        Image12.ImageUrl = ImageJ0.ImageUrl;
        Image13.ImageUrl = ImageJ0.ImageUrl;
        Image14.ImageUrl = ImageJ0.ImageUrl;
        Image15.ImageUrl = ImageJ0.ImageUrl;
        Image16.ImageUrl = ImageJ0.ImageUrl;
        Image17.ImageUrl = ImageJ0.ImageUrl;
        Image18.ImageUrl = ImageJ0.ImageUrl;
        Image19.ImageUrl = ImageJ0.ImageUrl;
        Image20.ImageUrl = ImageJ0.ImageUrl;
        Image21.ImageUrl = ImageJ0.ImageUrl;
        Image22.ImageUrl = ImageJ0.ImageUrl;
        Image23.ImageUrl = ImageJ0.ImageUrl;
        Image24.ImageUrl = ImageJ0.ImageUrl;
        Image25.ImageUrl = ImageJ0.ImageUrl;
        Image26.ImageUrl = ImageJ0.ImageUrl;
        Image27.ImageUrl = ImageJ0.ImageUrl;
        Image28.ImageUrl = ImageJ0.ImageUrl;
        Image29.ImageUrl = ImageJ0.ImageUrl;
        Image30.ImageUrl = ImageJ0.ImageUrl;
        Image31.ImageUrl = ImageJ0.ImageUrl;
        Image32.ImageUrl = ImageJ0.ImageUrl;
        Image33.ImageUrl = ImageJ0.ImageUrl;
        Image34.ImageUrl = ImageJ0.ImageUrl;
        Image35.ImageUrl = ImageJ0.ImageUrl;
        Image36.ImageUrl = ImageJ0.ImageUrl;
        Image37.ImageUrl = ImageJ0.ImageUrl;
        Image38.ImageUrl = ImageJ0.ImageUrl;
        Image39.ImageUrl = ImageJ0.ImageUrl;
        Image40.ImageUrl = ImageJ0.ImageUrl;
        Image41.ImageUrl = ImageJ0.ImageUrl;
        Image42.ImageUrl = ImageJ0.ImageUrl;
    }

    protected void TxtNom_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}
