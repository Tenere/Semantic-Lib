// This is the main DLL file.

#include "stdafx.h"
#include <opc/opc.h>
#include "LibOpcTextPlugin.h"
#include "LibOpcTextDocument.h"
#include <crtdbg.h>
#include <assert.h>

namespace SemanticLib { namespace LibOpcPlugin {

	LibOpcTextPlugin::LibOpcTextPlugin()
	{
		_CrtSetDbgFlag (_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
	}

	LibOpcTextPlugin::~LibOpcTextPlugin()
	{
		assert(!_CrtDumpMemoryLeaks());
	}

	ITextDocument^ LibOpcTextPlugin::CreateTextDocument(String^ fileName)
	{
		LibOpcTextDocument^ textDocument = gcnew LibOpcTextDocument(fileName);

		return textDocument;
	}

	ITextDocument^ LibOpcTextPlugin::OpenTextDocument(String^ fileName)
	{
		LibOpcTextDocument^ textDocument = gcnew LibOpcTextDocument(fileName);

		return textDocument;
	}
}}
