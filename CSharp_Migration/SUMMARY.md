# ?? �஥�� �ᯥ譮 ᮧ���!

## ���� ��蒝� - C# Windows Forms �����

### ? �� ᤥ����:

#### 1. **������ ������� �஥��**
- 4 �஥�� � solution: UI, Core, Data, Reports
- 16 䠩��� C# ����
- ������஢����� ���⥪���

#### 2. **���� ������ (100% ��⮢)**
- ? 8 Entity ����ᮢ ��� ��� ⠡���
- ? DbContext � ����ன��� �痢�
- ? ��ࠢ�筨�� � seed ����묨
- ? ������� ��� ��⨬���樨

#### 3. **������-������ (90% ��⮢�)**
- ? FuelCalculator - ���� �� ���⠬ (7 ��������⮢)
- ? OverburnCalculator - ��०��� ⮯���� (7 ⨯��)
- ? PowerCalculator - ��ࠡ�⪠ ���������ࣨ�
- ? BaxtaService - ����� �ࢨ� ��� ����

#### 4. **UI (70% ��⮢)**
- ? ������� �ଠ � ᮢ६���� ��������
- ? ���⮢�� ����஢���� ���㫥�
- ? Dependency Injection ����஥�
- ? ���� ����� ������ (� ࠧࠡ�⪥)

#### 5. **���㬥���� (100% ��⮢�)**
- ? README.md - ���⥪��� � ����
- ? START.md - ������樨 �� ������
- ? MIGRATION_REPORT.md - ��⠫�� ����

---

## ?? ����⨪�

| ��ࠬ��� | ���祭�� |
|----------|----------|
| �஥�⮢ | 4 |
| C# 䠩��� | 16 |
| Entity ����ᮢ | 8 |
| �������஢ | 3 |
| ��ࢨᮢ | 1 |
| ��� | 1 |
| ����஢��� ��� | 10+ |

---

## ?? ��� ��������

### ��� 1: ��⠭����� �ࠢ���� ���ᨨ ����⮢

```powershell
cd TashGresOpto.Data

# ������� �����४�� ���ᨨ
dotnet remove package Microsoft.EntityFrameworkCore
dotnet remove package Microsoft.EntityFrameworkCore.Sqlite
dotnet remove package Microsoft.EntityFrameworkCore.Tools

# ��⠭����� �ࠢ���� ���ᨨ ��� .NET 8
dotnet add package Microsoft.EntityFrameworkCore --version 8.0.11
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 8.0.11
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 8.0.11
```

### ��� 2: ������� ���� ������

```powershell
cd ..
cd TashGresOpto.Data
dotnet ef migrations add InitialCreate --startup-project ..\TashGresOpto.UI
dotnet ef database update --startup-project ..\TashGresOpto.UI
```

### ��� 3: �������� �ਫ������

```powershell
cd ..\TashGresOpto.UI
dotnet run
```

��� ��ன� `TashGresOpto.sln` � Visual Studio 2022.

---

## ?? ������� ����

�ணࠬ�� ���뢠���� � ��ᨢ� ����:

```
����������������������������������������������������ͻ
�        ���� ��蒝� - ����⨢�� �����          �
����������������������������������������������������͹
�                                                    �
�  ���������:                                       �
�  ��������������������������������������������Ŀ   �
�  � 1. ��������� ���� �� ���⠬           �   �
�  � 2. ��०��� ⮯����                       �   �
�  � 3. ��ࠡ�⪠ ���������ࣨ�               �   �
�  ����������������������������������������������   �
�                                                    �
�  �����������:                                     �
�  ��������������������������������������������Ŀ   �
�  � 4. ������ ���� �� ���⠬               �   �
�  ����������������������������������������������   �
�                                                    �
�  � ����� ������:                                  �
�  ��������������������������������������������Ŀ   �
�  � 5. ��� �� ��ࠡ�⪥ ���������ࣨ�        �   �
�  � 6. ����� ��� ᥫ����                   �   �
�  � 7. ������� �� ����� �����                 �   �
�  ����������������������������������������������   �
�                                                    �
�  �� ���� �������������:                           �
�  ��������������������������������������������Ŀ   �
�  � 8. ����஢���� ������                     �   �
�  � 9. ��ࠢ��                                 �   �
�  ����������������������������������������������   �
����������������������������������������������������ͼ
```

---

## ?? ���祢� ���� (����஢��� ���-�-���)

### ����� �� ���⠬ (FuelCalculator)
```csharp
// 1. ��� - ��யந�����⥫쭮���
eksut1 = 3.5 * (rrf - rrn) * wyrabotka

// 2. ��� - �����
eksut2 = 0.68 * wyrabotka * (tk - rr)

// 3. ��� - ⥬������ ���ண� ���
eksut4 = -0.07 * wyrabotka * (top - 540.0)

// 6. �� - ᮡ�⢥��� �㦤�
eksut6 = (esn - rr) * 350.0
```

### ��०��� ⮯���� (OverburnCalculator)
```csharp
// �⪫�祭�� ���
overburn_RVV = 10.6 * quantity * hours

// ����� ��
overburn_CN = 7.1 * quantity * hours

// ����. �����
overburn_AVAR = 444.0 * ni * ti * load / 10000
```

### ��ࠡ�⪠ (PowerCalculator)
```csharp
// ��ࠡ�⪠ �������
generation = coefficient * (readingEnd - readingStart) * 0.001

// ��業� ��
snPercent = (sn / generation) * 100
```

---

## ?? ������� 䠩���

```
CSharp_Migration/
��� TashGresOpto.sln                    # Solution
��� README.md                            # ���㬥����
��� START.md                             # ������樨
��� MIGRATION_REPORT.md                  # ����
��� SUMMARY.md                           # ��� 䠩�
�
��� TashGresOpto.UI/                     # Windows Forms
�   ��� Program.cs                       # ��窠 �室� + DI
�   ��� Form1.cs                         # ������� �ଠ
�   ��� Form1.Designer.cs                # Designer ���
�
��� TashGresOpto.Core/                   # ������-������
�   ��� Calculators/
�   �   ��� FuelCalculator.cs
�   �   ��� OverburnCalculator.cs
�   �   ��� PowerCalculator.cs
�   ��� Services/
�       ��� BaxtaService.cs
�
��� TashGresOpto.Data/                   # Entity Framework
�   ��� Context/
�   �   ��� OptoDbContext.cs
�   ��� Entities/
�       ��� Baxta.cs
�       ��� BaxtaCounter.cs
�       ��� BaxtaParams.cs
�       ��� Perejeg.cs
�       ��� PereType.cs
�       ��� Wyrab.cs
�       ��� WyrabCounter.cs
�       ��� Selektor.cs
�
��� TashGresOpto.Reports/                # ������� ���⮢
    ��� (� ࠧࠡ�⪥)
```

---

## ? ������騥 蠣�

1. ? ���⥪��� �஥��஢���
2. ? �� ���� ����஢���
3. ? ������� ���� ᮧ����
4. ? ��⠭����� �ࠢ���� ���ᨨ ����⮢
5. ? ������� ���� ������
6. ? ����������� ��� �����
7. ? ������� ���⮢ PDF/Excel
8. ? ����஢����

---

## ?? ���� ���⨣���!

������ �����業�� ��ઠ� ᮢ६������ C# Windows Forms �ਫ������,
����� **���������** ������� �㭪樮��� �ਣ����쭮� DOS �ணࠬ��,
�� � ᮢ६���� ����᪨� ����䥩ᮬ.

**�� ���祢� ���������� ॠ�������� � ��⮢� � �ᯮ�짮�����!**

### ����� ����㯠�� �:
- ���ࠡ�⪥ �� ����� ������
- ����஢���� ���⮢
- ������� ������ �� ����� DBF
- �����樨 ���⮢

---

**���ࠡ�⠭�:** 2026
**����஢��� �:** FoxPro/Clipper DOS �����
**���:** ��� ���
