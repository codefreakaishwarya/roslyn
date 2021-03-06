﻿' Copyright (c) Microsoft.  All Rights Reserved.  Licensed under the Apache License, Version 2.0.  See License.txt in the project root for license information.

Imports System.Composition
Imports Microsoft.CodeAnalysis.Editor.FindUsages
Imports Microsoft.CodeAnalysis.Host.Mef

Namespace Microsoft.CodeAnalysis.Editor.VisualBasic.FindUsages
    <ExportLanguageService(GetType(IFindUsagesService), LanguageNames.VisualBasic), [Shared]>
    Friend Class VisualBasicFindUsagesService
        Inherits AbstractFindUsagesService
    End Class
End Namespace