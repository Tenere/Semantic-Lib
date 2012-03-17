#include "Stdafx.h"
#include "LibOpcParagraphCollection.h"
#include "LibOpcParagraph.h"

namespace SemanticLib { namespace LibOpcPlugin {

	LibOpcParagraphCollection::LibOpcParagraphCollection(LibOpcTextDocument^ textDocument)
		: m_TextDocument(textDocument)
	{
	}

	IParagraph^ LibOpcParagraphCollection::Add()
	{
		LibOpcParagraph^ paragraph = gcnew LibOpcParagraph(m_TextDocument);

		return paragraph;
	}
}}