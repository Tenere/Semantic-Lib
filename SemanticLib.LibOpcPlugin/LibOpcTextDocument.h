#pragma once
#include "opc\opc.h"
#include "LibOpcParagraphCollection.h"

using namespace System;
using namespace SemanticLib::Core;
using namespace SemanticLib::Core::Collections;

namespace SemanticLib { namespace LibOpcPlugin {

	ref class LibOpcParagraphCollection;

	public ref class LibOpcTextDocument : ITextDocument
	{
	private:
		LibOpcParagraphCollection^ m_Paragraphs;

		opcContainer* m_Container;

	public:
		LibOpcTextDocument(String^ fileName);

		~LibOpcTextDocument();

		opcContainer* GetContainer() { return m_Container; }

		property ParagraphCollection^ Paragraphs
		{
			virtual ParagraphCollection^ get() { return (ParagraphCollection^)m_Paragraphs; }
		}

		property String^ SemanticMarkup
		{
			virtual String^ get() { return String::Empty; }

			virtual void set(String^ value) { }
		}
	};
}}