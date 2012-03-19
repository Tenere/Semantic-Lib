#include "stdafx.h"
#include "LibOpcTextDocument.h"

using namespace System::Runtime::InteropServices;

namespace SemanticLib { namespace LibOpcPlugin {

	LibOpcTextDocument::LibOpcTextDocument(String^ fileName)
	{
		m_Paragraphs = gcnew LibOpcParagraphCollection(this);

		char* pszFileName = (char*)Marshal::StringToHGlobalAnsi(fileName).ToPointer();

		if (OPC_ERROR_NONE != opcInitLibrary())
		{
			throw gcnew InvalidOperationException();
		}
		else
		{
			m_Container = opcContainerOpen(_X(pszFileName), OPC_OPEN_READ_WRITE, NULL, NULL);

			Marshal::FreeHGlobal(IntPtr(pszFileName));

			if (NULL == m_Container)
			{
				throw gcnew InvalidOperationException();
			}
		}
	}

	LibOpcTextDocument::~LibOpcTextDocument()
	{
		if (m_Container)
		{
			opcContainerClose(m_Container, OPC_CLOSE_NOW);
		}

		opcFreeLibrary();
	}
}}