﻿SELECT PrcCode, PrcName, DimCode, U_GR_UNEGORG FROM OPRC WHERE DimCode = ${param1} AND ISNULL(U_GR_UNEGORG, '') = '${param2}'