# Lab1-NT106
## Demo
### Main page

![Untitled](https://user-images.githubusercontent.com/95972670/227728782-1db3649b-f96a-4686-a489-f132def9bdac.png)

### Question 1: Calculator

![Untitled](https://user-images.githubusercontent.com/95972670/227728895-90215634-4702-423b-b73f-12e146b1f3d0.png)

### Question 2: Min, Max

![Untitled](https://user-images.githubusercontent.com/95972670/227728998-6a42bb3c-71ef-464f-97b8-0da8cb8762ed.png)

### Question 3: Read the number

![Untitled](https://user-images.githubusercontent.com/95972670/227729100-519de581-ab07-4edc-a8f7-5b20be697ed5.png)

### Question 4: Convert the number

![Untitled](https://user-images.githubusercontent.com/95972670/227729221-72095b4b-f5be-4430-8469-aae22767b345.png)

### Question 5: Manage Score

![Untitled](https://user-images.githubusercontent.com/95972670/227729358-0ae07d33-a3a1-4c8b-9e68-c607db2309d7.png)

## Calculator

Feature: calculate `+`, `-`, `*` and `/` with interger 32 bit

Exception: 

![Untitled](https://user-images.githubusercontent.com/95972670/227731444-97362417-c44d-4977-b36c-9fee3fa0efb1.png)

| Exception        | Idea             |
|------------------|------------------|
| Invalid string   | Message box      |
| Integer overflow | Casting to int64 |
| Divide zero      | Not allow        |

## Min, Max

**Feature:** find min number and max number in three numbers

**Exception:**

![Untitled](https://user-images.githubusercontent.com/95972670/227732478-5e71126a-e212-47e3-a3be-22fc98d82d12.png)

| Exception                  | Idea        |
|----------------------------|-------------|
| Invalid string             | Message box |
| Not enough input arguments | Message box |

## Read the number

**Feature:** convert numbers into words in Vietnamese

**Note:**

| Input | Output          | instead           |
|-------|-----------------|-------------------|
| 21    |  Hai mươi một   | Hai mươi mốt      |
| 105   | Một trăm lẻ năm | Một trăm linh năm |

Because differences in pronunciation of each region

## Convert the number

**Feature:** convert a base 10 to base 2 or 16 and vice versa

**Note:** 

| Input |  Type    | Base       | Output        |
|-------|----------|------------|---------------|
| 123   | integer  | Dec to Hex | 7b            |
| 123   | Fraction | Dec to Hex | 405ec00000000 |

**Because:**
  - Case type = **integer**, output: int32 format
  - Case type = **fraction**, output:  double-precision 64-bit format IEEE 754 values
  
 ### Manage Score
 
 **Feature:** 
  - Display list scores of student's subjects
  - Calc min score, max score, the average score
  - Number of subjects passed, unpassed
  - Ranked
  
**Note:** Results displayed are rounded to 2 decimal places
  
![Untitled](https://user-images.githubusercontent.com/95972670/227733696-ac233ada-62fc-4edf-a95b-586169d112ba.png)

