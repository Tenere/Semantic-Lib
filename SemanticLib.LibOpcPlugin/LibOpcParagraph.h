#pragma once
#include "LibOpcTextDocument.h"

using namespace System;
using namespace SemanticLib::Core;
using namespace SemanticLib::Core::Collections;

namespace SemanticLib { namespace LibOpcPlugin {

	public ref class LibOpcParagraph : IParagraph
	{
	private:
		LibOpcTextDocument^ m_TextDocument;

	public:
		LibOpcParagraph(LibOpcTextDocument^ textDocument);

		property String^ SemanticMarkup
		{
			virtual String^ get() { return String::Empty; }

			virtual void set(String^ value) { }
		}

		property RangeCollection^ Ranges
		{
			virtual RangeCollection^ get() { return nullptr; }
		}
	};
}}