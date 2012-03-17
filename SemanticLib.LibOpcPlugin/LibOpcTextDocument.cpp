#include "stdafx.h"
#include "LibOpcTextDocument.h"

using namespace System::Runtime::InteropServices;

namespace SemanticLib { namespace LibOpcPlugin {

	LibOpcTextDocument::LibOpcTextDocument(String^ fileName)
	{
		m_Paragraphs = gcnew LibOpcParagraphCollection(this);

		char* pszFileName = (char*)Marshal::StringToHGlobalAuto(fileName).ToPointer();

		opc_error_t err = opcInitLibrary();
		if (OPC_ERROR_NONE != err)
		{
			throw gcnew InvalidOperationException();
		}
		else
		{
			m_Container = opcContainerOpen(_X(pszFileName), OPC_OPEN_READ_ONLY, NULL, NULL);
			const char partName[] = "word/document.xml";

			//opcPart part = opcPartFind(m_Container, _X(partName), NULL, 0);
			opcPart part = opcPartGetFirst(m_Container);
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