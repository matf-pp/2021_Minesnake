#pragma once

#include <cstdlib>
#include "MSManager.cpp"

namespace Application3 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for MyForm
	/// </summary>
	public ref class Level1 : public System::Windows::Forms::Form {
	private:
		array<PictureBox^>^ pBoxes = gcnew array<PictureBox^>(100);
		array<bool>^ visitedGrid = gcnew array<bool>(100);
		String^ name; // Player name
		Button^ button1;
	private: System::Windows::Forms::Timer^ timer1;
		   MSManager* game = new MSManager();
		
	public:
		Level1(String^ name) {
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
			this->name = name;
		}
	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~Level1() {
			if (components) {
				delete components;
			}
		}

	protected:

	public: System::Windows::Forms::Label^ label1;
	public: System::Windows::Forms::Label^ label2;
	private: System::ComponentModel::IContainer^ components;
	public:



	public: System::Windows::Forms::PictureBox^ pictureBox1;
	public: System::Windows::Forms::PictureBox^ pictureBox2;
	public: System::Windows::Forms::PictureBox^ pictureBox3;
	public: System::Windows::Forms::PictureBox^ pictureBox4;
	public: System::Windows::Forms::PictureBox^ pictureBox5;
	public: System::Windows::Forms::PictureBox^ pictureBox6;
	public: System::Windows::Forms::PictureBox^ pictureBox7;
	public: System::Windows::Forms::PictureBox^ pictureBox8;
	public: System::Windows::Forms::PictureBox^ pictureBox9;
	public: System::Windows::Forms::PictureBox^ pictureBox10;
	public: System::Windows::Forms::PictureBox^ pictureBox11;
	public: System::Windows::Forms::PictureBox^ pictureBox12;
	public: System::Windows::Forms::PictureBox^ pictureBox13;
	public: System::Windows::Forms::PictureBox^ pictureBox14;
	public: System::Windows::Forms::PictureBox^ pictureBox15;
	public: System::Windows::Forms::PictureBox^ pictureBox16;
	public: System::Windows::Forms::PictureBox^ pictureBox17;
	public: System::Windows::Forms::PictureBox^ pictureBox18;
	public: System::Windows::Forms::PictureBox^ pictureBox19;
	public: System::Windows::Forms::PictureBox^ pictureBox20;
	public: System::Windows::Forms::PictureBox^ pictureBox21;
	public: System::Windows::Forms::PictureBox^ pictureBox22;
	public: System::Windows::Forms::PictureBox^ pictureBox23;
	public: System::Windows::Forms::PictureBox^ pictureBox24;
	public: System::Windows::Forms::PictureBox^ pictureBox25;
	public: System::Windows::Forms::PictureBox^ pictureBox26;
	public: System::Windows::Forms::PictureBox^ pictureBox27;
	public: System::Windows::Forms::PictureBox^ pictureBox28;
	public: System::Windows::Forms::PictureBox^ pictureBox29;
	public: System::Windows::Forms::PictureBox^ pictureBox30;
	public: System::Windows::Forms::PictureBox^ pictureBox31;
	public: System::Windows::Forms::PictureBox^ pictureBox32;
	public: System::Windows::Forms::PictureBox^ pictureBox33;
	public: System::Windows::Forms::PictureBox^ pictureBox34;
	public: System::Windows::Forms::PictureBox^ pictureBox35;
	public: System::Windows::Forms::PictureBox^ pictureBox36;
	public: System::Windows::Forms::PictureBox^ pictureBox37;
	public: System::Windows::Forms::PictureBox^ pictureBox38;
	public: System::Windows::Forms::PictureBox^ pictureBox39;
	public: System::Windows::Forms::PictureBox^ pictureBox40;
	public: System::Windows::Forms::PictureBox^ pictureBox41;
	public: System::Windows::Forms::PictureBox^ pictureBox42;
	public: System::Windows::Forms::PictureBox^ pictureBox43;
	public: System::Windows::Forms::PictureBox^ pictureBox44;
	public: System::Windows::Forms::PictureBox^ pictureBox45;
	public: System::Windows::Forms::PictureBox^ pictureBox46;
	public: System::Windows::Forms::PictureBox^ pictureBox47;
	public: System::Windows::Forms::PictureBox^ pictureBox48;
	public: System::Windows::Forms::PictureBox^ pictureBox49;
	public: System::Windows::Forms::PictureBox^ pictureBox50;
	public: System::Windows::Forms::PictureBox^ pictureBox51;
	public: System::Windows::Forms::PictureBox^ pictureBox52;
	public: System::Windows::Forms::PictureBox^ pictureBox53;
	public: System::Windows::Forms::PictureBox^ pictureBox54;
	public: System::Windows::Forms::PictureBox^ pictureBox55;
	public: System::Windows::Forms::PictureBox^ pictureBox56;
	public: System::Windows::Forms::PictureBox^ pictureBox57;
	public: System::Windows::Forms::PictureBox^ pictureBox58;
	public: System::Windows::Forms::PictureBox^ pictureBox59;
	public: System::Windows::Forms::PictureBox^ pictureBox60;
	public: System::Windows::Forms::PictureBox^ pictureBox61;
	public: System::Windows::Forms::PictureBox^ pictureBox62;
	public: System::Windows::Forms::PictureBox^ pictureBox63;
	public: System::Windows::Forms::PictureBox^ pictureBox64;
	public: System::Windows::Forms::PictureBox^ pictureBox65;
	public: System::Windows::Forms::PictureBox^ pictureBox66;
	public: System::Windows::Forms::PictureBox^ pictureBox67;
	public: System::Windows::Forms::PictureBox^ pictureBox68;
	public: System::Windows::Forms::PictureBox^ pictureBox69;
	public: System::Windows::Forms::PictureBox^ pictureBox70;
	public: System::Windows::Forms::PictureBox^ pictureBox71;
	public: System::Windows::Forms::PictureBox^ pictureBox72;
	public: System::Windows::Forms::PictureBox^ pictureBox73;
	public: System::Windows::Forms::PictureBox^ pictureBox74;
	public: System::Windows::Forms::PictureBox^ pictureBox75;
	public: System::Windows::Forms::PictureBox^ pictureBox76;
	public: System::Windows::Forms::PictureBox^ pictureBox77;
	public: System::Windows::Forms::PictureBox^ pictureBox78;
	public: System::Windows::Forms::PictureBox^ pictureBox79;
	public: System::Windows::Forms::PictureBox^ pictureBox80;
	public: System::Windows::Forms::PictureBox^ pictureBox81;
	public: System::Windows::Forms::PictureBox^ pictureBox82;
	public: System::Windows::Forms::PictureBox^ pictureBox83;
	public: System::Windows::Forms::PictureBox^ pictureBox84;
	public: System::Windows::Forms::PictureBox^ pictureBox85;
	public: System::Windows::Forms::PictureBox^ pictureBox86;
	public: System::Windows::Forms::PictureBox^ pictureBox87;
	public: System::Windows::Forms::PictureBox^ pictureBox88;
	public: System::Windows::Forms::PictureBox^ pictureBox89;
	public: System::Windows::Forms::PictureBox^ pictureBox90;
	public: System::Windows::Forms::PictureBox^ pictureBox91;
	public: System::Windows::Forms::PictureBox^ pictureBox92;
	public: System::Windows::Forms::PictureBox^ pictureBox93;
	public: System::Windows::Forms::PictureBox^ pictureBox94;
	public: System::Windows::Forms::PictureBox^ pictureBox95;
	public: System::Windows::Forms::PictureBox^ pictureBox96;
	public: System::Windows::Forms::PictureBox^ pictureBox97;
	public: System::Windows::Forms::PictureBox^ pictureBox98;
	public: System::Windows::Forms::PictureBox^ pictureBox99;
	public: System::Windows::Forms::PictureBox^ pictureBox100;

		   /// <summary>
		   /// Required designer variable.
		   /// </summary>


#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		   void InitializeComponent(void)
		   {
			   this->components = (gcnew System::ComponentModel::Container());
			   this->label1 = (gcnew System::Windows::Forms::Label());
			   this->label2 = (gcnew System::Windows::Forms::Label());
			   this->button1 = (gcnew System::Windows::Forms::Button());
			   this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox2 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox3 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox4 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox5 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox6 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox7 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox8 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox9 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox10 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox11 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox12 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox13 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox14 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox15 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox16 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox17 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox18 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox19 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox20 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox21 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox22 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox23 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox24 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox25 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox26 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox27 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox28 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox29 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox30 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox31 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox32 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox33 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox34 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox35 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox36 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox37 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox38 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox39 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox40 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox41 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox42 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox43 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox44 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox45 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox46 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox47 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox48 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox49 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox50 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox51 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox52 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox53 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox54 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox55 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox56 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox57 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox58 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox59 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox60 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox61 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox62 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox63 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox64 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox65 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox66 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox67 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox68 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox69 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox70 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox71 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox72 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox73 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox74 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox75 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox76 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox77 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox78 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox79 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox80 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox81 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox82 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox83 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox84 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox85 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox86 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox87 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox88 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox89 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox90 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox91 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox92 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox93 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox94 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox95 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox96 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox97 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox98 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox99 = (gcnew System::Windows::Forms::PictureBox());
			   this->pictureBox100 = (gcnew System::Windows::Forms::PictureBox());
			   this->timer1 = (gcnew System::Windows::Forms::Timer(this->components));
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox2))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox3))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox4))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox5))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox6))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox7))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox8))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox9))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox10))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox11))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox12))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox13))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox14))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox15))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox16))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox17))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox18))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox19))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox20))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox21))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox22))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox23))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox24))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox25))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox26))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox27))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox28))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox29))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox30))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox31))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox32))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox33))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox34))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox35))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox36))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox37))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox38))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox39))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox40))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox41))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox42))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox43))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox44))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox45))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox46))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox47))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox48))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox49))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox50))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox51))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox52))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox53))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox54))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox55))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox56))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox57))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox58))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox59))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox60))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox61))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox62))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox63))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox64))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox65))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox66))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox67))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox68))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox69))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox70))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox71))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox72))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox73))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox74))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox75))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox76))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox77))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox78))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox79))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox80))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox81))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox82))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox83))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox84))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox85))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox86))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox87))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox88))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox89))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox90))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox91))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox92))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox93))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox94))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox95))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox96))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox97))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox98))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox99))->BeginInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox100))->BeginInit();
			   this->SuspendLayout();
			   // 
			   // label1
			   // 
			   this->label1->AutoSize = true;
			   this->label1->Font = (gcnew System::Drawing::Font(L"Times New Roman", 14.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				   static_cast<System::Byte>(0)));
			   this->label1->ForeColor = System::Drawing::SystemColors::ActiveBorder;
			   this->label1->Location = System::Drawing::Point(467, 121);
			   this->label1->Name = L"label1";
			   this->label1->Size = System::Drawing::Size(95, 22);
			   this->label1->TabIndex = 130;
			   this->label1->Text = L"ImeIgraca";
			   // 
			   // label2
			   // 
			   this->label2->AutoSize = true;
			   this->label2->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->label2->Font = (gcnew System::Drawing::Font(L"Stencil", 20.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				   static_cast<System::Byte>(0)));
			   this->label2->Location = System::Drawing::Point(155, 15);
			   this->label2->Name = L"label2";
			   this->label2->Size = System::Drawing::Size(113, 32);
			   this->label2->TabIndex = 131;
			   this->label2->Text = L"LEVEL1";
			   // 
			   // button1
			   // 
			   this->button1->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->button1->Font = (gcnew System::Drawing::Font(L"Stencil", 18, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				   static_cast<System::Byte>(0)));
			   this->button1->Location = System::Drawing::Point(459, 403);
			   this->button1->Name = L"button1";
			   this->button1->Size = System::Drawing::Size(173, 52);
			   this->button1->TabIndex = 212;
			   this->button1->Text = L"EXIT GAME";
			   this->button1->UseVisualStyleBackColor = false;
			   this->button1->Click += gcnew System::EventHandler(this, &Level1::button1_Click);
			   // 
			   // pictureBox1
			   // 
			   this->pictureBox1->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox1->Location = System::Drawing::Point(12, 67);
			   this->pictureBox1->Name = L"pictureBox1";
			   this->pictureBox1->Size = System::Drawing::Size(41, 37);
			   this->pictureBox1->TabIndex = 30;
			   this->pictureBox1->TabStop = false;
			   this->pictureBox1->Click += gcnew System::EventHandler(this, &Level1::pictureBox1_Click);
			   // 
			   // pictureBox2
			   // 
			   this->pictureBox2->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox2->Location = System::Drawing::Point(55, 67);
			   this->pictureBox2->Name = L"pictureBox2";
			   this->pictureBox2->Size = System::Drawing::Size(41, 37);
			   this->pictureBox2->TabIndex = 31;
			   this->pictureBox2->TabStop = false;
			   // 
			   // pictureBox3
			   // 
			   this->pictureBox3->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox3->Location = System::Drawing::Point(98, 67);
			   this->pictureBox3->Name = L"pictureBox3";
			   this->pictureBox3->Size = System::Drawing::Size(41, 37);
			   this->pictureBox3->TabIndex = 32;
			   this->pictureBox3->TabStop = false;
			   // 
			   // pictureBox4
			   // 
			   this->pictureBox4->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox4->Location = System::Drawing::Point(141, 67);
			   this->pictureBox4->Name = L"pictureBox4";
			   this->pictureBox4->Size = System::Drawing::Size(41, 37);
			   this->pictureBox4->TabIndex = 33;
			   this->pictureBox4->TabStop = false;
			   // 
			   // pictureBox5
			   // 
			   this->pictureBox5->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox5->Location = System::Drawing::Point(184, 67);
			   this->pictureBox5->Name = L"pictureBox5";
			   this->pictureBox5->Size = System::Drawing::Size(41, 37);
			   this->pictureBox5->TabIndex = 34;
			   this->pictureBox5->TabStop = false;
			   // 
			   // pictureBox6
			   // 
			   this->pictureBox6->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox6->Location = System::Drawing::Point(227, 67);
			   this->pictureBox6->Name = L"pictureBox6";
			   this->pictureBox6->Size = System::Drawing::Size(41, 37);
			   this->pictureBox6->TabIndex = 35;
			   this->pictureBox6->TabStop = false;
			   // 
			   // pictureBox7
			   // 
			   this->pictureBox7->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox7->Location = System::Drawing::Point(270, 67);
			   this->pictureBox7->Name = L"pictureBox7";
			   this->pictureBox7->Size = System::Drawing::Size(41, 37);
			   this->pictureBox7->TabIndex = 36;
			   this->pictureBox7->TabStop = false;
			   // 
			   // pictureBox8
			   // 
			   this->pictureBox8->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox8->Location = System::Drawing::Point(313, 67);
			   this->pictureBox8->Name = L"pictureBox8";
			   this->pictureBox8->Size = System::Drawing::Size(41, 37);
			   this->pictureBox8->TabIndex = 37;
			   this->pictureBox8->TabStop = false;
			   // 
			   // pictureBox9
			   // 
			   this->pictureBox9->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox9->Location = System::Drawing::Point(356, 67);
			   this->pictureBox9->Name = L"pictureBox9";
			   this->pictureBox9->Size = System::Drawing::Size(41, 37);
			   this->pictureBox9->TabIndex = 38;
			   this->pictureBox9->TabStop = false;
			   this->pictureBox9->Click += gcnew System::EventHandler(this, &Level1::pictureBox9_Click);
			   // 
			   // pictureBox10
			   // 
			   this->pictureBox10->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox10->Location = System::Drawing::Point(399, 67);
			   this->pictureBox10->Name = L"pictureBox10";
			   this->pictureBox10->Size = System::Drawing::Size(41, 37);
			   this->pictureBox10->TabIndex = 39;
			   this->pictureBox10->TabStop = false;
			   this->pictureBox10->Click += gcnew System::EventHandler(this, &Level1::pictureBox10_Click);
			   this->pictureBox10->MouseDown += gcnew System::Windows::Forms::MouseEventHandler(this, &Level1::pictureBox10_MouseDown);
			   // 
			   // pictureBox11
			   // 
			   this->pictureBox11->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox11->Location = System::Drawing::Point(12, 106);
			   this->pictureBox11->Name = L"pictureBox11";
			   this->pictureBox11->Size = System::Drawing::Size(41, 37);
			   this->pictureBox11->TabIndex = 40;
			   this->pictureBox11->TabStop = false;
			   // 
			   // pictureBox12
			   // 
			   this->pictureBox12->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox12->Location = System::Drawing::Point(55, 106);
			   this->pictureBox12->Name = L"pictureBox12";
			   this->pictureBox12->Size = System::Drawing::Size(41, 37);
			   this->pictureBox12->TabIndex = 41;
			   this->pictureBox12->TabStop = false;
			   // 
			   // pictureBox13
			   // 
			   this->pictureBox13->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox13->Location = System::Drawing::Point(98, 106);
			   this->pictureBox13->Name = L"pictureBox13";
			   this->pictureBox13->Size = System::Drawing::Size(41, 37);
			   this->pictureBox13->TabIndex = 42;
			   this->pictureBox13->TabStop = false;
			   // 
			   // pictureBox14
			   // 
			   this->pictureBox14->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox14->Location = System::Drawing::Point(141, 106);
			   this->pictureBox14->Name = L"pictureBox14";
			   this->pictureBox14->Size = System::Drawing::Size(41, 37);
			   this->pictureBox14->TabIndex = 43;
			   this->pictureBox14->TabStop = false;
			   // 
			   // pictureBox15
			   // 
			   this->pictureBox15->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox15->Location = System::Drawing::Point(184, 106);
			   this->pictureBox15->Name = L"pictureBox15";
			   this->pictureBox15->Size = System::Drawing::Size(41, 37);
			   this->pictureBox15->TabIndex = 44;
			   this->pictureBox15->TabStop = false;
			   // 
			   // pictureBox16
			   // 
			   this->pictureBox16->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox16->Location = System::Drawing::Point(227, 106);
			   this->pictureBox16->Name = L"pictureBox16";
			   this->pictureBox16->Size = System::Drawing::Size(41, 37);
			   this->pictureBox16->TabIndex = 45;
			   this->pictureBox16->TabStop = false;
			   // 
			   // pictureBox17
			   // 
			   this->pictureBox17->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox17->Location = System::Drawing::Point(270, 106);
			   this->pictureBox17->Name = L"pictureBox17";
			   this->pictureBox17->Size = System::Drawing::Size(41, 37);
			   this->pictureBox17->TabIndex = 46;
			   this->pictureBox17->TabStop = false;
			   // 
			   // pictureBox18
			   // 
			   this->pictureBox18->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox18->Location = System::Drawing::Point(313, 106);
			   this->pictureBox18->Name = L"pictureBox18";
			   this->pictureBox18->Size = System::Drawing::Size(41, 37);
			   this->pictureBox18->TabIndex = 47;
			   this->pictureBox18->TabStop = false;
			   // 
			   // pictureBox19
			   // 
			   this->pictureBox19->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox19->Location = System::Drawing::Point(356, 106);
			   this->pictureBox19->Name = L"pictureBox19";
			   this->pictureBox19->Size = System::Drawing::Size(41, 37);
			   this->pictureBox19->TabIndex = 48;
			   this->pictureBox19->TabStop = false;
			   // 
			   // pictureBox20
			   // 
			   this->pictureBox20->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox20->Location = System::Drawing::Point(399, 106);
			   this->pictureBox20->Name = L"pictureBox20";
			   this->pictureBox20->Size = System::Drawing::Size(41, 37);
			   this->pictureBox20->TabIndex = 49;
			   this->pictureBox20->TabStop = false;
			   // 
			   // pictureBox21
			   // 
			   this->pictureBox21->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox21->Location = System::Drawing::Point(12, 145);
			   this->pictureBox21->Name = L"pictureBox21";
			   this->pictureBox21->Size = System::Drawing::Size(41, 37);
			   this->pictureBox21->TabIndex = 151;
			   this->pictureBox21->TabStop = false;
			   // 
			   // pictureBox22
			   // 
			   this->pictureBox22->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox22->Location = System::Drawing::Point(55, 145);
			   this->pictureBox22->Name = L"pictureBox22";
			   this->pictureBox22->Size = System::Drawing::Size(41, 37);
			   this->pictureBox22->TabIndex = 150;
			   this->pictureBox22->TabStop = false;
			   // 
			   // pictureBox23
			   // 
			   this->pictureBox23->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox23->Location = System::Drawing::Point(98, 145);
			   this->pictureBox23->Name = L"pictureBox23";
			   this->pictureBox23->Size = System::Drawing::Size(41, 37);
			   this->pictureBox23->TabIndex = 149;
			   this->pictureBox23->TabStop = false;
			   // 
			   // pictureBox24
			   // 
			   this->pictureBox24->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox24->Location = System::Drawing::Point(141, 145);
			   this->pictureBox24->Name = L"pictureBox24";
			   this->pictureBox24->Size = System::Drawing::Size(41, 37);
			   this->pictureBox24->TabIndex = 148;
			   this->pictureBox24->TabStop = false;
			   // 
			   // pictureBox25
			   // 
			   this->pictureBox25->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox25->Location = System::Drawing::Point(184, 145);
			   this->pictureBox25->Name = L"pictureBox25";
			   this->pictureBox25->Size = System::Drawing::Size(41, 37);
			   this->pictureBox25->TabIndex = 147;
			   this->pictureBox25->TabStop = false;
			   // 
			   // pictureBox26
			   // 
			   this->pictureBox26->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox26->Location = System::Drawing::Point(227, 145);
			   this->pictureBox26->Name = L"pictureBox26";
			   this->pictureBox26->Size = System::Drawing::Size(41, 37);
			   this->pictureBox26->TabIndex = 146;
			   this->pictureBox26->TabStop = false;
			   // 
			   // pictureBox27
			   // 
			   this->pictureBox27->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox27->Location = System::Drawing::Point(270, 145);
			   this->pictureBox27->Name = L"pictureBox27";
			   this->pictureBox27->Size = System::Drawing::Size(41, 37);
			   this->pictureBox27->TabIndex = 145;
			   this->pictureBox27->TabStop = false;
			   // 
			   // pictureBox28
			   // 
			   this->pictureBox28->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox28->Location = System::Drawing::Point(313, 145);
			   this->pictureBox28->Name = L"pictureBox28";
			   this->pictureBox28->Size = System::Drawing::Size(41, 37);
			   this->pictureBox28->TabIndex = 144;
			   this->pictureBox28->TabStop = false;
			   // 
			   // pictureBox29
			   // 
			   this->pictureBox29->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox29->Location = System::Drawing::Point(356, 145);
			   this->pictureBox29->Name = L"pictureBox29";
			   this->pictureBox29->Size = System::Drawing::Size(41, 37);
			   this->pictureBox29->TabIndex = 143;
			   this->pictureBox29->TabStop = false;
			   // 
			   // pictureBox30
			   // 
			   this->pictureBox30->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox30->Location = System::Drawing::Point(399, 145);
			   this->pictureBox30->Name = L"pictureBox30";
			   this->pictureBox30->Size = System::Drawing::Size(41, 37);
			   this->pictureBox30->TabIndex = 142;
			   this->pictureBox30->TabStop = false;
			   // 
			   // pictureBox31
			   // 
			   this->pictureBox31->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox31->Location = System::Drawing::Point(12, 184);
			   this->pictureBox31->Name = L"pictureBox31";
			   this->pictureBox31->Size = System::Drawing::Size(41, 37);
			   this->pictureBox31->TabIndex = 141;
			   this->pictureBox31->TabStop = false;
			   // 
			   // pictureBox32
			   // 
			   this->pictureBox32->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox32->Location = System::Drawing::Point(55, 184);
			   this->pictureBox32->Name = L"pictureBox32";
			   this->pictureBox32->Size = System::Drawing::Size(41, 37);
			   this->pictureBox32->TabIndex = 140;
			   this->pictureBox32->TabStop = false;
			   // 
			   // pictureBox33
			   // 
			   this->pictureBox33->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox33->Location = System::Drawing::Point(98, 184);
			   this->pictureBox33->Name = L"pictureBox33";
			   this->pictureBox33->Size = System::Drawing::Size(41, 37);
			   this->pictureBox33->TabIndex = 139;
			   this->pictureBox33->TabStop = false;
			   // 
			   // pictureBox34
			   // 
			   this->pictureBox34->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox34->Location = System::Drawing::Point(141, 184);
			   this->pictureBox34->Name = L"pictureBox34";
			   this->pictureBox34->Size = System::Drawing::Size(41, 37);
			   this->pictureBox34->TabIndex = 138;
			   this->pictureBox34->TabStop = false;
			   // 
			   // pictureBox35
			   // 
			   this->pictureBox35->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox35->Location = System::Drawing::Point(184, 184);
			   this->pictureBox35->Name = L"pictureBox35";
			   this->pictureBox35->Size = System::Drawing::Size(41, 37);
			   this->pictureBox35->TabIndex = 137;
			   this->pictureBox35->TabStop = false;
			   // 
			   // pictureBox36
			   // 
			   this->pictureBox36->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox36->Location = System::Drawing::Point(227, 184);
			   this->pictureBox36->Name = L"pictureBox36";
			   this->pictureBox36->Size = System::Drawing::Size(41, 37);
			   this->pictureBox36->TabIndex = 136;
			   this->pictureBox36->TabStop = false;
			   // 
			   // pictureBox37
			   // 
			   this->pictureBox37->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox37->Location = System::Drawing::Point(270, 184);
			   this->pictureBox37->Name = L"pictureBox37";
			   this->pictureBox37->Size = System::Drawing::Size(41, 37);
			   this->pictureBox37->TabIndex = 135;
			   this->pictureBox37->TabStop = false;
			   // 
			   // pictureBox38
			   // 
			   this->pictureBox38->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox38->Location = System::Drawing::Point(313, 184);
			   this->pictureBox38->Name = L"pictureBox38";
			   this->pictureBox38->Size = System::Drawing::Size(41, 37);
			   this->pictureBox38->TabIndex = 134;
			   this->pictureBox38->TabStop = false;
			   // 
			   // pictureBox39
			   // 
			   this->pictureBox39->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox39->Location = System::Drawing::Point(356, 184);
			   this->pictureBox39->Name = L"pictureBox39";
			   this->pictureBox39->Size = System::Drawing::Size(41, 37);
			   this->pictureBox39->TabIndex = 133;
			   this->pictureBox39->TabStop = false;
			   // 
			   // pictureBox40
			   // 
			   this->pictureBox40->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox40->Location = System::Drawing::Point(399, 184);
			   this->pictureBox40->Name = L"pictureBox40";
			   this->pictureBox40->Size = System::Drawing::Size(41, 37);
			   this->pictureBox40->TabIndex = 132;
			   this->pictureBox40->TabStop = false;
			   // 
			   // pictureBox41
			   // 
			   this->pictureBox41->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox41->Location = System::Drawing::Point(12, 223);
			   this->pictureBox41->Name = L"pictureBox41";
			   this->pictureBox41->Size = System::Drawing::Size(41, 37);
			   this->pictureBox41->TabIndex = 171;
			   this->pictureBox41->TabStop = false;
			   // 
			   // pictureBox42
			   // 
			   this->pictureBox42->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox42->Location = System::Drawing::Point(55, 223);
			   this->pictureBox42->Name = L"pictureBox42";
			   this->pictureBox42->Size = System::Drawing::Size(41, 37);
			   this->pictureBox42->TabIndex = 170;
			   this->pictureBox42->TabStop = false;
			   // 
			   // pictureBox43
			   // 
			   this->pictureBox43->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox43->Location = System::Drawing::Point(98, 223);
			   this->pictureBox43->Name = L"pictureBox43";
			   this->pictureBox43->Size = System::Drawing::Size(41, 37);
			   this->pictureBox43->TabIndex = 169;
			   this->pictureBox43->TabStop = false;
			   // 
			   // pictureBox44
			   // 
			   this->pictureBox44->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox44->Location = System::Drawing::Point(141, 223);
			   this->pictureBox44->Name = L"pictureBox44";
			   this->pictureBox44->Size = System::Drawing::Size(41, 37);
			   this->pictureBox44->TabIndex = 168;
			   this->pictureBox44->TabStop = false;
			   // 
			   // pictureBox45
			   // 
			   this->pictureBox45->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox45->Location = System::Drawing::Point(184, 223);
			   this->pictureBox45->Name = L"pictureBox45";
			   this->pictureBox45->Size = System::Drawing::Size(41, 37);
			   this->pictureBox45->TabIndex = 167;
			   this->pictureBox45->TabStop = false;
			   // 
			   // pictureBox46
			   // 
			   this->pictureBox46->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox46->Location = System::Drawing::Point(227, 223);
			   this->pictureBox46->Name = L"pictureBox46";
			   this->pictureBox46->Size = System::Drawing::Size(41, 37);
			   this->pictureBox46->TabIndex = 166;
			   this->pictureBox46->TabStop = false;
			   // 
			   // pictureBox47
			   // 
			   this->pictureBox47->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox47->Location = System::Drawing::Point(270, 223);
			   this->pictureBox47->Name = L"pictureBox47";
			   this->pictureBox47->Size = System::Drawing::Size(41, 37);
			   this->pictureBox47->TabIndex = 165;
			   this->pictureBox47->TabStop = false;
			   // 
			   // pictureBox48
			   // 
			   this->pictureBox48->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox48->Location = System::Drawing::Point(313, 223);
			   this->pictureBox48->Name = L"pictureBox48";
			   this->pictureBox48->Size = System::Drawing::Size(41, 37);
			   this->pictureBox48->TabIndex = 164;
			   this->pictureBox48->TabStop = false;
			   // 
			   // pictureBox49
			   // 
			   this->pictureBox49->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox49->Location = System::Drawing::Point(356, 223);
			   this->pictureBox49->Name = L"pictureBox49";
			   this->pictureBox49->Size = System::Drawing::Size(41, 37);
			   this->pictureBox49->TabIndex = 163;
			   this->pictureBox49->TabStop = false;
			   // 
			   // pictureBox50
			   // 
			   this->pictureBox50->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox50->Location = System::Drawing::Point(399, 223);
			   this->pictureBox50->Name = L"pictureBox50";
			   this->pictureBox50->Size = System::Drawing::Size(41, 37);
			   this->pictureBox50->TabIndex = 162;
			   this->pictureBox50->TabStop = false;
			   // 
			   // pictureBox51
			   // 
			   this->pictureBox51->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox51->Location = System::Drawing::Point(12, 262);
			   this->pictureBox51->Name = L"pictureBox51";
			   this->pictureBox51->Size = System::Drawing::Size(41, 37);
			   this->pictureBox51->TabIndex = 161;
			   this->pictureBox51->TabStop = false;
			   // 
			   // pictureBox52
			   // 
			   this->pictureBox52->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox52->Location = System::Drawing::Point(55, 262);
			   this->pictureBox52->Name = L"pictureBox52";
			   this->pictureBox52->Size = System::Drawing::Size(41, 37);
			   this->pictureBox52->TabIndex = 160;
			   this->pictureBox52->TabStop = false;
			   // 
			   // pictureBox53
			   // 
			   this->pictureBox53->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox53->Location = System::Drawing::Point(98, 262);
			   this->pictureBox53->Name = L"pictureBox53";
			   this->pictureBox53->Size = System::Drawing::Size(41, 37);
			   this->pictureBox53->TabIndex = 159;
			   this->pictureBox53->TabStop = false;
			   // 
			   // pictureBox54
			   // 
			   this->pictureBox54->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox54->Location = System::Drawing::Point(141, 262);
			   this->pictureBox54->Name = L"pictureBox54";
			   this->pictureBox54->Size = System::Drawing::Size(41, 37);
			   this->pictureBox54->TabIndex = 158;
			   this->pictureBox54->TabStop = false;
			   // 
			   // pictureBox55
			   // 
			   this->pictureBox55->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox55->Location = System::Drawing::Point(184, 262);
			   this->pictureBox55->Name = L"pictureBox55";
			   this->pictureBox55->Size = System::Drawing::Size(41, 37);
			   this->pictureBox55->TabIndex = 157;
			   this->pictureBox55->TabStop = false;
			   // 
			   // pictureBox56
			   // 
			   this->pictureBox56->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox56->Location = System::Drawing::Point(227, 262);
			   this->pictureBox56->Name = L"pictureBox56";
			   this->pictureBox56->Size = System::Drawing::Size(41, 37);
			   this->pictureBox56->TabIndex = 156;
			   this->pictureBox56->TabStop = false;
			   // 
			   // pictureBox57
			   // 
			   this->pictureBox57->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox57->Location = System::Drawing::Point(270, 262);
			   this->pictureBox57->Name = L"pictureBox57";
			   this->pictureBox57->Size = System::Drawing::Size(41, 37);
			   this->pictureBox57->TabIndex = 155;
			   this->pictureBox57->TabStop = false;
			   // 
			   // pictureBox58
			   // 
			   this->pictureBox58->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox58->Location = System::Drawing::Point(313, 262);
			   this->pictureBox58->Name = L"pictureBox58";
			   this->pictureBox58->Size = System::Drawing::Size(41, 37);
			   this->pictureBox58->TabIndex = 154;
			   this->pictureBox58->TabStop = false;
			   this->pictureBox58->Click += gcnew System::EventHandler(this, &Level1::pictureBox58_Click);
			   // 
			   // pictureBox59
			   // 
			   this->pictureBox59->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox59->Location = System::Drawing::Point(356, 262);
			   this->pictureBox59->Name = L"pictureBox59";
			   this->pictureBox59->Size = System::Drawing::Size(41, 37);
			   this->pictureBox59->TabIndex = 153;
			   this->pictureBox59->TabStop = false;
			   // 
			   // pictureBox60
			   // 
			   this->pictureBox60->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox60->Location = System::Drawing::Point(399, 262);
			   this->pictureBox60->Name = L"pictureBox60";
			   this->pictureBox60->Size = System::Drawing::Size(41, 37);
			   this->pictureBox60->TabIndex = 152;
			   this->pictureBox60->TabStop = false;
			   // 
			   // pictureBox61
			   // 
			   this->pictureBox61->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox61->Location = System::Drawing::Point(12, 301);
			   this->pictureBox61->Name = L"pictureBox61";
			   this->pictureBox61->Size = System::Drawing::Size(41, 37);
			   this->pictureBox61->TabIndex = 191;
			   this->pictureBox61->TabStop = false;
			   // 
			   // pictureBox62
			   // 
			   this->pictureBox62->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox62->Location = System::Drawing::Point(55, 301);
			   this->pictureBox62->Name = L"pictureBox62";
			   this->pictureBox62->Size = System::Drawing::Size(41, 37);
			   this->pictureBox62->TabIndex = 190;
			   this->pictureBox62->TabStop = false;
			   // 
			   // pictureBox63
			   // 
			   this->pictureBox63->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox63->Location = System::Drawing::Point(98, 301);
			   this->pictureBox63->Name = L"pictureBox63";
			   this->pictureBox63->Size = System::Drawing::Size(41, 37);
			   this->pictureBox63->TabIndex = 189;
			   this->pictureBox63->TabStop = false;
			   // 
			   // pictureBox64
			   // 
			   this->pictureBox64->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox64->Location = System::Drawing::Point(141, 301);
			   this->pictureBox64->Name = L"pictureBox64";
			   this->pictureBox64->Size = System::Drawing::Size(41, 37);
			   this->pictureBox64->TabIndex = 188;
			   this->pictureBox64->TabStop = false;
			   // 
			   // pictureBox65
			   // 
			   this->pictureBox65->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox65->Location = System::Drawing::Point(184, 301);
			   this->pictureBox65->Name = L"pictureBox65";
			   this->pictureBox65->Size = System::Drawing::Size(41, 37);
			   this->pictureBox65->TabIndex = 187;
			   this->pictureBox65->TabStop = false;
			   // 
			   // pictureBox66
			   // 
			   this->pictureBox66->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox66->Location = System::Drawing::Point(227, 301);
			   this->pictureBox66->Name = L"pictureBox66";
			   this->pictureBox66->Size = System::Drawing::Size(41, 37);
			   this->pictureBox66->TabIndex = 186;
			   this->pictureBox66->TabStop = false;
			   // 
			   // pictureBox67
			   // 
			   this->pictureBox67->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox67->Location = System::Drawing::Point(270, 301);
			   this->pictureBox67->Name = L"pictureBox67";
			   this->pictureBox67->Size = System::Drawing::Size(41, 37);
			   this->pictureBox67->TabIndex = 185;
			   this->pictureBox67->TabStop = false;
			   // 
			   // pictureBox68
			   // 
			   this->pictureBox68->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox68->Location = System::Drawing::Point(313, 301);
			   this->pictureBox68->Name = L"pictureBox68";
			   this->pictureBox68->Size = System::Drawing::Size(41, 37);
			   this->pictureBox68->TabIndex = 184;
			   this->pictureBox68->TabStop = false;
			   // 
			   // pictureBox69
			   // 
			   this->pictureBox69->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox69->Location = System::Drawing::Point(356, 301);
			   this->pictureBox69->Name = L"pictureBox69";
			   this->pictureBox69->Size = System::Drawing::Size(41, 37);
			   this->pictureBox69->TabIndex = 183;
			   this->pictureBox69->TabStop = false;
			   // 
			   // pictureBox70
			   // 
			   this->pictureBox70->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox70->Location = System::Drawing::Point(399, 301);
			   this->pictureBox70->Name = L"pictureBox70";
			   this->pictureBox70->Size = System::Drawing::Size(41, 37);
			   this->pictureBox70->TabIndex = 182;
			   this->pictureBox70->TabStop = false;
			   // 
			   // pictureBox71
			   // 
			   this->pictureBox71->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox71->Location = System::Drawing::Point(12, 340);
			   this->pictureBox71->Name = L"pictureBox71";
			   this->pictureBox71->Size = System::Drawing::Size(41, 37);
			   this->pictureBox71->TabIndex = 181;
			   this->pictureBox71->TabStop = false;
			   // 
			   // pictureBox72
			   // 
			   this->pictureBox72->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox72->Location = System::Drawing::Point(55, 340);
			   this->pictureBox72->Name = L"pictureBox72";
			   this->pictureBox72->Size = System::Drawing::Size(41, 37);
			   this->pictureBox72->TabIndex = 180;
			   this->pictureBox72->TabStop = false;
			   // 
			   // pictureBox73
			   // 
			   this->pictureBox73->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox73->Location = System::Drawing::Point(98, 340);
			   this->pictureBox73->Name = L"pictureBox73";
			   this->pictureBox73->Size = System::Drawing::Size(41, 37);
			   this->pictureBox73->TabIndex = 179;
			   this->pictureBox73->TabStop = false;
			   // 
			   // pictureBox74
			   // 
			   this->pictureBox74->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox74->Location = System::Drawing::Point(141, 340);
			   this->pictureBox74->Name = L"pictureBox74";
			   this->pictureBox74->Size = System::Drawing::Size(41, 37);
			   this->pictureBox74->TabIndex = 178;
			   this->pictureBox74->TabStop = false;
			   // 
			   // pictureBox75
			   // 
			   this->pictureBox75->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox75->Location = System::Drawing::Point(184, 340);
			   this->pictureBox75->Name = L"pictureBox75";
			   this->pictureBox75->Size = System::Drawing::Size(41, 37);
			   this->pictureBox75->TabIndex = 177;
			   this->pictureBox75->TabStop = false;
			   // 
			   // pictureBox76
			   // 
			   this->pictureBox76->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox76->Location = System::Drawing::Point(227, 340);
			   this->pictureBox76->Name = L"pictureBox76";
			   this->pictureBox76->Size = System::Drawing::Size(41, 37);
			   this->pictureBox76->TabIndex = 176;
			   this->pictureBox76->TabStop = false;
			   // 
			   // pictureBox77
			   // 
			   this->pictureBox77->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox77->Location = System::Drawing::Point(270, 340);
			   this->pictureBox77->Name = L"pictureBox77";
			   this->pictureBox77->Size = System::Drawing::Size(41, 37);
			   this->pictureBox77->TabIndex = 175;
			   this->pictureBox77->TabStop = false;
			   // 
			   // pictureBox78
			   // 
			   this->pictureBox78->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox78->Location = System::Drawing::Point(313, 340);
			   this->pictureBox78->Name = L"pictureBox78";
			   this->pictureBox78->Size = System::Drawing::Size(41, 37);
			   this->pictureBox78->TabIndex = 174;
			   this->pictureBox78->TabStop = false;
			   // 
			   // pictureBox79
			   // 
			   this->pictureBox79->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox79->Location = System::Drawing::Point(356, 340);
			   this->pictureBox79->Name = L"pictureBox79";
			   this->pictureBox79->Size = System::Drawing::Size(41, 37);
			   this->pictureBox79->TabIndex = 173;
			   this->pictureBox79->TabStop = false;
			   // 
			   // pictureBox80
			   // 
			   this->pictureBox80->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox80->Location = System::Drawing::Point(399, 340);
			   this->pictureBox80->Name = L"pictureBox80";
			   this->pictureBox80->Size = System::Drawing::Size(41, 37);
			   this->pictureBox80->TabIndex = 172;
			   this->pictureBox80->TabStop = false;
			   // 
			   // pictureBox81
			   // 
			   this->pictureBox81->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox81->Location = System::Drawing::Point(12, 379);
			   this->pictureBox81->Name = L"pictureBox81";
			   this->pictureBox81->Size = System::Drawing::Size(41, 37);
			   this->pictureBox81->TabIndex = 211;
			   this->pictureBox81->TabStop = false;
			   // 
			   // pictureBox82
			   // 
			   this->pictureBox82->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox82->Location = System::Drawing::Point(55, 379);
			   this->pictureBox82->Name = L"pictureBox82";
			   this->pictureBox82->Size = System::Drawing::Size(41, 37);
			   this->pictureBox82->TabIndex = 210;
			   this->pictureBox82->TabStop = false;
			   // 
			   // pictureBox83
			   // 
			   this->pictureBox83->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox83->Location = System::Drawing::Point(98, 379);
			   this->pictureBox83->Name = L"pictureBox83";
			   this->pictureBox83->Size = System::Drawing::Size(41, 37);
			   this->pictureBox83->TabIndex = 209;
			   this->pictureBox83->TabStop = false;
			   // 
			   // pictureBox84
			   // 
			   this->pictureBox84->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox84->Location = System::Drawing::Point(141, 379);
			   this->pictureBox84->Name = L"pictureBox84";
			   this->pictureBox84->Size = System::Drawing::Size(41, 37);
			   this->pictureBox84->TabIndex = 208;
			   this->pictureBox84->TabStop = false;
			   // 
			   // pictureBox85
			   // 
			   this->pictureBox85->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox85->Location = System::Drawing::Point(184, 379);
			   this->pictureBox85->Name = L"pictureBox85";
			   this->pictureBox85->Size = System::Drawing::Size(41, 37);
			   this->pictureBox85->TabIndex = 207;
			   this->pictureBox85->TabStop = false;
			   // 
			   // pictureBox86
			   // 
			   this->pictureBox86->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox86->Location = System::Drawing::Point(227, 379);
			   this->pictureBox86->Name = L"pictureBox86";
			   this->pictureBox86->Size = System::Drawing::Size(41, 37);
			   this->pictureBox86->TabIndex = 206;
			   this->pictureBox86->TabStop = false;
			   // 
			   // pictureBox87
			   // 
			   this->pictureBox87->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox87->Location = System::Drawing::Point(270, 379);
			   this->pictureBox87->Name = L"pictureBox87";
			   this->pictureBox87->Size = System::Drawing::Size(41, 37);
			   this->pictureBox87->TabIndex = 205;
			   this->pictureBox87->TabStop = false;
			   // 
			   // pictureBox88
			   // 
			   this->pictureBox88->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox88->Location = System::Drawing::Point(313, 379);
			   this->pictureBox88->Name = L"pictureBox88";
			   this->pictureBox88->Size = System::Drawing::Size(41, 37);
			   this->pictureBox88->TabIndex = 204;
			   this->pictureBox88->TabStop = false;
			   // 
			   // pictureBox89
			   // 
			   this->pictureBox89->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox89->Location = System::Drawing::Point(356, 379);
			   this->pictureBox89->Name = L"pictureBox89";
			   this->pictureBox89->Size = System::Drawing::Size(41, 37);
			   this->pictureBox89->TabIndex = 203;
			   this->pictureBox89->TabStop = false;
			   // 
			   // pictureBox90
			   // 
			   this->pictureBox90->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox90->Location = System::Drawing::Point(399, 379);
			   this->pictureBox90->Name = L"pictureBox90";
			   this->pictureBox90->Size = System::Drawing::Size(41, 37);
			   this->pictureBox90->TabIndex = 202;
			   this->pictureBox90->TabStop = false;
			   // 
			   // pictureBox91
			   // 
			   this->pictureBox91->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox91->Location = System::Drawing::Point(12, 418);
			   this->pictureBox91->Name = L"pictureBox91";
			   this->pictureBox91->Size = System::Drawing::Size(41, 37);
			   this->pictureBox91->TabIndex = 201;
			   this->pictureBox91->TabStop = false;
			   // 
			   // pictureBox92
			   // 
			   this->pictureBox92->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox92->Location = System::Drawing::Point(55, 418);
			   this->pictureBox92->Name = L"pictureBox92";
			   this->pictureBox92->Size = System::Drawing::Size(41, 37);
			   this->pictureBox92->TabIndex = 200;
			   this->pictureBox92->TabStop = false;
			   // 
			   // pictureBox93
			   // 
			   this->pictureBox93->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox93->Location = System::Drawing::Point(98, 418);
			   this->pictureBox93->Name = L"pictureBox93";
			   this->pictureBox93->Size = System::Drawing::Size(41, 37);
			   this->pictureBox93->TabIndex = 199;
			   this->pictureBox93->TabStop = false;
			   // 
			   // pictureBox94
			   // 
			   this->pictureBox94->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox94->Location = System::Drawing::Point(141, 418);
			   this->pictureBox94->Name = L"pictureBox94";
			   this->pictureBox94->Size = System::Drawing::Size(41, 37);
			   this->pictureBox94->TabIndex = 198;
			   this->pictureBox94->TabStop = false;
			   // 
			   // pictureBox95
			   // 
			   this->pictureBox95->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox95->Location = System::Drawing::Point(184, 418);
			   this->pictureBox95->Name = L"pictureBox95";
			   this->pictureBox95->Size = System::Drawing::Size(41, 37);
			   this->pictureBox95->TabIndex = 197;
			   this->pictureBox95->TabStop = false;
			   // 
			   // pictureBox96
			   // 
			   this->pictureBox96->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox96->Location = System::Drawing::Point(227, 418);
			   this->pictureBox96->Name = L"pictureBox96";
			   this->pictureBox96->Size = System::Drawing::Size(41, 37);
			   this->pictureBox96->TabIndex = 196;
			   this->pictureBox96->TabStop = false;
			   // 
			   // pictureBox97
			   // 
			   this->pictureBox97->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox97->Location = System::Drawing::Point(270, 418);
			   this->pictureBox97->Name = L"pictureBox97";
			   this->pictureBox97->Size = System::Drawing::Size(41, 37);
			   this->pictureBox97->TabIndex = 195;
			   this->pictureBox97->TabStop = false;
			   // 
			   // pictureBox98
			   // 
			   this->pictureBox98->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox98->Location = System::Drawing::Point(313, 418);
			   this->pictureBox98->Name = L"pictureBox98";
			   this->pictureBox98->Size = System::Drawing::Size(41, 37);
			   this->pictureBox98->TabIndex = 194;
			   this->pictureBox98->TabStop = false;
			   // 
			   // pictureBox99
			   // 
			   this->pictureBox99->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox99->Location = System::Drawing::Point(356, 418);
			   this->pictureBox99->Name = L"pictureBox99";
			   this->pictureBox99->Size = System::Drawing::Size(41, 37);
			   this->pictureBox99->TabIndex = 193;
			   this->pictureBox99->TabStop = false;
			   // 
			   // pictureBox100
			   // 
			   this->pictureBox100->BackColor = System::Drawing::SystemColors::ActiveBorder;
			   this->pictureBox100->Location = System::Drawing::Point(399, 418);
			   this->pictureBox100->Name = L"pictureBox100";
			   this->pictureBox100->Size = System::Drawing::Size(41, 37);
			   this->pictureBox100->TabIndex = 192;
			   this->pictureBox100->TabStop = false;
			   // 
			   // timer1
			   // 
			   this->timer1->Tick += gcnew System::EventHandler(this, &Level1::timer1_Tick);
			   // 
			   // Level1
			   // 
			   this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			   this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			   this->BackColor = System::Drawing::SystemColors::ActiveCaptionText;
			   this->ClientSize = System::Drawing::Size(653, 467);
			   this->Controls->Add(this->button1);
			   this->Controls->Add(this->pictureBox81);
			   this->Controls->Add(this->pictureBox82);
			   this->Controls->Add(this->pictureBox83);
			   this->Controls->Add(this->pictureBox84);
			   this->Controls->Add(this->pictureBox85);
			   this->Controls->Add(this->pictureBox86);
			   this->Controls->Add(this->pictureBox87);
			   this->Controls->Add(this->pictureBox88);
			   this->Controls->Add(this->pictureBox89);
			   this->Controls->Add(this->pictureBox90);
			   this->Controls->Add(this->pictureBox91);
			   this->Controls->Add(this->pictureBox92);
			   this->Controls->Add(this->pictureBox93);
			   this->Controls->Add(this->pictureBox94);
			   this->Controls->Add(this->pictureBox95);
			   this->Controls->Add(this->pictureBox96);
			   this->Controls->Add(this->pictureBox97);
			   this->Controls->Add(this->pictureBox98);
			   this->Controls->Add(this->pictureBox99);
			   this->Controls->Add(this->pictureBox100);
			   this->Controls->Add(this->pictureBox61);
			   this->Controls->Add(this->pictureBox62);
			   this->Controls->Add(this->pictureBox63);
			   this->Controls->Add(this->pictureBox64);
			   this->Controls->Add(this->pictureBox65);
			   this->Controls->Add(this->pictureBox66);
			   this->Controls->Add(this->pictureBox67);
			   this->Controls->Add(this->pictureBox68);
			   this->Controls->Add(this->pictureBox69);
			   this->Controls->Add(this->pictureBox70);
			   this->Controls->Add(this->pictureBox71);
			   this->Controls->Add(this->pictureBox72);
			   this->Controls->Add(this->pictureBox73);
			   this->Controls->Add(this->pictureBox74);
			   this->Controls->Add(this->pictureBox75);
			   this->Controls->Add(this->pictureBox76);
			   this->Controls->Add(this->pictureBox77);
			   this->Controls->Add(this->pictureBox78);
			   this->Controls->Add(this->pictureBox79);
			   this->Controls->Add(this->pictureBox80);
			   this->Controls->Add(this->pictureBox41);
			   this->Controls->Add(this->pictureBox42);
			   this->Controls->Add(this->pictureBox43);
			   this->Controls->Add(this->pictureBox44);
			   this->Controls->Add(this->pictureBox45);
			   this->Controls->Add(this->pictureBox46);
			   this->Controls->Add(this->pictureBox47);
			   this->Controls->Add(this->pictureBox48);
			   this->Controls->Add(this->pictureBox49);
			   this->Controls->Add(this->pictureBox50);
			   this->Controls->Add(this->pictureBox51);
			   this->Controls->Add(this->pictureBox52);
			   this->Controls->Add(this->pictureBox53);
			   this->Controls->Add(this->pictureBox54);
			   this->Controls->Add(this->pictureBox55);
			   this->Controls->Add(this->pictureBox56);
			   this->Controls->Add(this->pictureBox57);
			   this->Controls->Add(this->pictureBox58);
			   this->Controls->Add(this->pictureBox59);
			   this->Controls->Add(this->pictureBox60);
			   this->Controls->Add(this->pictureBox21);
			   this->Controls->Add(this->pictureBox22);
			   this->Controls->Add(this->pictureBox23);
			   this->Controls->Add(this->pictureBox24);
			   this->Controls->Add(this->pictureBox25);
			   this->Controls->Add(this->pictureBox26);
			   this->Controls->Add(this->pictureBox27);
			   this->Controls->Add(this->pictureBox28);
			   this->Controls->Add(this->pictureBox29);
			   this->Controls->Add(this->pictureBox30);
			   this->Controls->Add(this->pictureBox31);
			   this->Controls->Add(this->pictureBox32);
			   this->Controls->Add(this->pictureBox33);
			   this->Controls->Add(this->pictureBox34);
			   this->Controls->Add(this->pictureBox35);
			   this->Controls->Add(this->pictureBox36);
			   this->Controls->Add(this->pictureBox37);
			   this->Controls->Add(this->pictureBox38);
			   this->Controls->Add(this->pictureBox39);
			   this->Controls->Add(this->pictureBox40);
			   this->Controls->Add(this->label2);
			   this->Controls->Add(this->label1);
			   this->Controls->Add(this->pictureBox20);
			   this->Controls->Add(this->pictureBox19);
			   this->Controls->Add(this->pictureBox18);
			   this->Controls->Add(this->pictureBox17);
			   this->Controls->Add(this->pictureBox16);
			   this->Controls->Add(this->pictureBox15);
			   this->Controls->Add(this->pictureBox14);
			   this->Controls->Add(this->pictureBox13);
			   this->Controls->Add(this->pictureBox12);
			   this->Controls->Add(this->pictureBox11);
			   this->Controls->Add(this->pictureBox10);
			   this->Controls->Add(this->pictureBox9);
			   this->Controls->Add(this->pictureBox8);
			   this->Controls->Add(this->pictureBox7);
			   this->Controls->Add(this->pictureBox6);
			   this->Controls->Add(this->pictureBox5);
			   this->Controls->Add(this->pictureBox4);
			   this->Controls->Add(this->pictureBox3);
			   this->Controls->Add(this->pictureBox2);
			   this->Controls->Add(this->pictureBox1);
			   this->Name = L"Level1";
			   this->Text = L"MyForm";
			   this->Load += gcnew System::EventHandler(this, &Level1::MyForm_Load);
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox2))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox3))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox4))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox5))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox6))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox7))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox8))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox9))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox10))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox11))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox12))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox13))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox14))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox15))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox16))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox17))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox18))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox19))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox20))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox21))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox22))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox23))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox24))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox25))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox26))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox27))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox28))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox29))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox30))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox31))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox32))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox33))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox34))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox35))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox36))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox37))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox38))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox39))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox40))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox41))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox42))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox43))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox44))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox45))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox46))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox47))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox48))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox49))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox50))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox51))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox52))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox53))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox54))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox55))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox56))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox57))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox58))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox59))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox60))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox61))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox62))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox63))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox64))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox65))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox66))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox67))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox68))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox69))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox70))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox71))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox72))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox73))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox74))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox75))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox76))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox77))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox78))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox79))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox80))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox81))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox82))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox83))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox84))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox85))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox86))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox87))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox88))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox89))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox90))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox91))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox92))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox93))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox94))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox95))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox96))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox97))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox98))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox99))->EndInit();
			   (cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox100))->EndInit();
			   this->ResumeLayout(false);
			   this->PerformLayout();

		   }
#pragma endregion
	
	public: System::Void pictureBox1_Click(System::Object^ sender, System::EventArgs^ e) {
		// Bitmap^ image = gcnew Bitmap("pictures\\bomb2.jpg"); // \\ bacause name starts with number...
		// pictureBox1->Image = image;
	}
	public: System::Void MyForm_Load(System::Object^ sender, System::EventArgs^ e) {
		// Player name
		label1->Text = name;

		// Initialization of pBoxes
		pBoxes[0] = pictureBox1;
		pBoxes[1] = pictureBox2;
		pBoxes[2] = pictureBox3;
		pBoxes[3] = pictureBox4;
		pBoxes[4] = pictureBox5;
		pBoxes[5] = pictureBox6;
		pBoxes[6] = pictureBox7;
		pBoxes[7] = pictureBox8;
		pBoxes[8] = pictureBox9;
		pBoxes[9] = pictureBox10;

		pBoxes[10] = pictureBox11;
		pBoxes[11] = pictureBox12;
		pBoxes[12] = pictureBox13;
		pBoxes[13] = pictureBox14;
		pBoxes[14] = pictureBox15;
		pBoxes[15] = pictureBox16;
		pBoxes[16] = pictureBox17;
		pBoxes[17] = pictureBox18;
		pBoxes[18] = pictureBox19;
		pBoxes[19] = pictureBox20;

		pBoxes[20] = pictureBox21;
		pBoxes[21] = pictureBox22;
		pBoxes[22] = pictureBox23;
		pBoxes[23] = pictureBox24;
		pBoxes[24] = pictureBox25;
		pBoxes[25] = pictureBox26;
		pBoxes[26] = pictureBox27;
		pBoxes[27] = pictureBox28;
		pBoxes[28] = pictureBox29;
		pBoxes[29] = pictureBox30;

		pBoxes[30] = pictureBox31;
		pBoxes[31] = pictureBox32;
		pBoxes[32] = pictureBox33;
		pBoxes[33] = pictureBox34;
		pBoxes[34] = pictureBox35;
		pBoxes[35] = pictureBox36;
		pBoxes[36] = pictureBox37;
		pBoxes[37] = pictureBox38;
		pBoxes[38] = pictureBox39;
		pBoxes[39] = pictureBox40;

		pBoxes[40] = pictureBox41;
		pBoxes[41] = pictureBox42;
		pBoxes[42] = pictureBox43;
		pBoxes[43] = pictureBox44;
		pBoxes[44] = pictureBox45;
		pBoxes[45] = pictureBox46;
		pBoxes[46] = pictureBox47;
		pBoxes[47] = pictureBox48;
		pBoxes[48] = pictureBox49;
		pBoxes[49] = pictureBox50;

		pBoxes[50] = pictureBox51;
		pBoxes[51] = pictureBox52;
		pBoxes[52] = pictureBox53;
		pBoxes[53] = pictureBox54;
		pBoxes[54] = pictureBox55;
		pBoxes[55] = pictureBox56;
		pBoxes[56] = pictureBox57;
		pBoxes[57] = pictureBox58;
		pBoxes[58] = pictureBox59;
		pBoxes[59] = pictureBox60;

		pBoxes[60] = pictureBox61;
		pBoxes[61] = pictureBox62;
		pBoxes[62] = pictureBox63;
		pBoxes[63] = pictureBox64;
		pBoxes[64] = pictureBox65;
		pBoxes[65] = pictureBox66;
		pBoxes[66] = pictureBox67;
		pBoxes[67] = pictureBox68;
		pBoxes[68] = pictureBox69;
		pBoxes[69] = pictureBox70;

		pBoxes[70] = pictureBox71;
		pBoxes[71] = pictureBox72;
		pBoxes[72] = pictureBox73;
		pBoxes[73] = pictureBox74;
		pBoxes[74] = pictureBox75;
		pBoxes[75] = pictureBox76;
		pBoxes[76] = pictureBox77;
		pBoxes[77] = pictureBox78;
		pBoxes[78] = pictureBox79;
		pBoxes[79] = pictureBox80;

		pBoxes[80] = pictureBox81;
		pBoxes[81] = pictureBox82;
		pBoxes[82] = pictureBox83;
		pBoxes[83] = pictureBox84;
		pBoxes[84] = pictureBox85;
		pBoxes[85] = pictureBox86;
		pBoxes[86] = pictureBox87;
		pBoxes[87] = pictureBox88;
		pBoxes[88] = pictureBox89;
		pBoxes[89] = pictureBox90;

		pBoxes[90] = pictureBox91;
		pBoxes[91] = pictureBox92;
		pBoxes[92] = pictureBox93;
		pBoxes[93] = pictureBox94;
		pBoxes[94] = pictureBox95;
		pBoxes[95] = pictureBox96;
		pBoxes[96] = pictureBox97;
		pBoxes[97] = pictureBox98;
		pBoxes[98] = pictureBox99;
		pBoxes[99] = pictureBox100;
		
		for (int i = 0; i < 100; i++) {
			visitedGrid[i] = false;
		}

		pin_ptr<PictureBox^> pBoxesTmp = &pBoxes[0];
		pin_ptr<bool> visitedGridTmp = &visitedGrid[0];


		// Start of the game
		std::vector<int> a = { 0 };
		game->prepare(10, 10, 4, 0, 3, a, a, 0, 10, pBoxesTmp, visitedGridTmp);
		game->repaint();
		timer1->Interval = 100;
		game->play(1000);
		timer1->Start();
	}


	public: System::Void pictureBox58_Click(System::Object^ sender, System::EventArgs^ e) {

	}
	public: System::Void pictureBox9_Click(System::Object^ sender, System::EventArgs^ e) {
		game->standardOpen(0,8,true);
	}

	public: System::Void pictureBox9_DoubleClick(System::Object^ sender, System::EventArgs^ e) {
		game->specialOpen(0, 8);
	}

	public: void pictureBox10_MouseDown(Object^ sender, System::Windows::Forms::MouseEventArgs^ e) {
			if (e->Button::get() == ::MouseButtons::Left) {
				game->standardOpen(0, 9, true);
			}

			if (e->Button::get() == ::MouseButtons::Right) {
				game->specialOpen(0, 9);
			}

			int result = game->checkResult();
			if (result == 0) {
				MessageBox::Show("YOU WIN. CONGRATS! :)");
			}
			else if (result == -1) {
				MessageBox::Show("YOU LOSE :(");
			}
    }
	public: System::Void button1_Click(System::Object^ sender, System::EventArgs^ e) {
		this->Close();
	}
public: System::Void pictureBox10_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void timer1_Tick(System::Object^ sender, System::EventArgs^ e) {
	try {
		game->repaint();
	}
	catch (...) {
		
	}
}
};
}