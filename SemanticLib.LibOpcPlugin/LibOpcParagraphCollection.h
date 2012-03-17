#pragma once
#include "LibOpcTextDocument.h"

using namespace System;
using namespace SemanticLib::Core;
using namespace SemanticLib::Core::Collections;

namespace SemanticLib { namespace LibOpcPlugin {

	ref class LibOpcTextDocument;

	public ref class LibOpcParagraphCollection : ParagraphCollection
	{
	private:
		LibOpcTextDocument^ m_TextDocument;

	public:
		LibOpcParagraphCollection(LibOpcTextDocument^ textDocument);

		virtual IParagraph^ Add() override;
	};
}}