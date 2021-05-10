#include "MyForm.h"

using namespace System;
using namespace System::Windows::Forms; 

[STAThread]

int main(array<String^>^ args) {
	 Application::SetCompatibleTextRenderingDefault(false);
	 Application::EnableVisualStyles();
	 Application3::MyForm form;
	 Application::Run(% form);

	 return 0;
 }

