#include "Stdafx.h"
#include "LibOpcParagraph.h"

namespace SemanticLib { namespace LibOpcPlugin {
	
	LibOpcParagraph::LibOpcParagraph(LibOpcTextDocument^ textDocument)
		: m_TextDocument(textDocument)
	{
		opcContainer* container = m_TextDocument->GetContainer();
		opcPart firstPart = opcPartGetFirst(container);

		opcContainerDump(container, stdout);
		for (opcPart part = opcPartGetFirst(container); OPC_PART_INVALID != part; part = opcPartGetNext(container, part))
		{
			const xmlChar* type = opcPartGetType(container, part);p
		}

		const char partName[] = "word/document";
		opcPart part = opcPartFind(container, _X(partName), NULL, 0);
		if (OPC_PART_INVALID != part)
		{
			mceTextWriter *writer = mceTextWriterOpen(container, part, OPC_COMPRESSIONOPTION_FAST);
			const char v1[] = "http://schemas.openxmlformats.org/wordprocessingml/2006/main";

			mceTextWriterStartDocument(writer);
			mceTextWriterRegisterNamespace(writer, _X(v1), NULL, MCE_DEFAULT);
			mceTextWriterStartElement(writer, _X(v1), _X("p"));
			mceTextWriterStartElement(writer, _X(v1), _X("r"));
			mceTextWriterStartElement(writer, _X(v1), _X("t"));
			mceTextWriterStartElement(writer, _X(v1), _X("t"));
			mceTextWriterWriteString(writer, _X("Hello, World!"));

			mceTextWriterEndDocument(writer);
			mceTextWriterFree(writer);
		}
	}
}}