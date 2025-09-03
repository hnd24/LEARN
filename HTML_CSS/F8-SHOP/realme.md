## Function

-1- linear-gradient() : tạo một dãy màu gradient tuyến tính

    @ EX : background: linear-gradient(45deg, red, yellow);

-2- calc() : dùng để tính toán

    @ EX : calc(80% +20px)

-3- attr() : dùng để lấy giá trị và sữ dụng nó nhiều lần

    @ EX :

    div::before {
    content: attr(data-label);
    }

   <div data-label="Hello, World!"></div>

//--------------------------------------------------------------------//

## Pseudo classes

-1- ::root{} : tạo biển html toàn cục

    @ EX :

    :root {
    --primary-color: #007bff;
    --secondary-color: #ff6600;
    }

    body {
    background-color: var(--primary-color);
    }

    button {
    background-color: var(--secondary-color);
    }

-2- :hover{} : thực hiện lệnh khi di chuột qua

    @ EX :

    a:hover {
    color: red; /_ Changes the text color to red when hovering over a link _/
    }

    button:hover {
    background-color: #00ff00; /_ Changes the background color to green when hovering over a button _/
    }

-3- :active{} : thực hiện khi bấm và giữ chuột ở vùng chỉ định

    @ EX :

    a:active {
    color: red; /_ Changes the link text color to red when it's being clicked _/
    }

    button:active {
    background-color: #00ff00; /_ Changes the button background color to green when it's being clicked _/
    }

//--------------------------------------------------------------------//

## Pesudo Elements

-1- ::first-letter {} : thiết kế chữ cái đầu tiên của dòng
-2- ::first-line {} : thiết kế dòng dầu tiên
-3- ::selection {} : thiết kế vùng dung chuột tô đen

//--------------------------------------------------------------------//

## Positon (ưu tiên left và top hơn với bottom và right)

-1- Relatve : tạo vị trí của chính mình, phụ thuộc vị trí của chính mình

    @ EX :

    .my-element {
    position: relative;
    top: 10px; /_ Shifts the element 10 pixels down from its default position _/
    left: 20px; /_ Shifts the element 20 pixels to the right of its default position _/
    }

-2- Absolute : thể được thiết kế sẽ phụ thuộc vào thẻ cha gần nhất có position

    @ EX :

    .my-element {
    position: relative;
    top: 10px; /_ Shifts the element 10 pixels down from its default position _/
    left: 20px; /_ Shifts the element 20 pixels to the right of its default position _/
    }

-3- fixed : dứng yên đù có lăn chuột thay đổi khung hình đi đâu đi nữa

    @EX :

    .my-fixed-element {
    position: fixed;
    top: 10px;
    right: 20px;
    }

//--------------------------------------------------------------------//

## flexbox ( main axis vuồng góc với cross axis )

-1- display : flex / inline-flex ( quyết định xem có sữ dụng flexbox hay không )

    @ flex : Nó biến container thành một khối (block-level) và các phần tử con bên trong sẽ sắp xếp theo hướng dọc và cả hàng ngang.

    @ inline-flex : biến container thành một phần tử nằm trong dòng văn bản (inline-level). Các phần tử con trong container sẽ được xếp thành CHỈ một dòng

-2- flex-direciton : row / column (thay đổi hướng của của main axis)

    @ row : (seting defual) theo chiều ngang

    @ colum : theo chiều dọc

-3- justify-content : flex-start / flex-end / center / space-bettween / space-around /space-evenly (nằm ở container và hiệu chỉnh vị trí của các item con theo chiều của MAIN AXIS)

    @ space-bettween : căn chỉnh các item con RA 2 BÊN theo chiều của MAIN AXIS

    @ space-around : căn chỉnh các item con tách ra , khoãng cách 2 mép bằng 1/2 khoãng cách giữa các item

    @ space-evenly : căn chỉnh các item con căn đều các khoảng

-4- justify-sefl : flex-start / flex-end / center ( điều chỉnh vị trí của các item con)

-5- align-content : flex-start / flex-end / center / space-bettween / space-around /space-evenly (nằm ở container và hiệu chỉnh vị trí của các item con theo chiều của CROSS AXIS)

-6- align-sefl : flex-start / flex-end / center ( điều chỉnh vị trí của các item con)

-7- flex : <number> (đặt giá trị giữa các item con với nhau trong container )

-8- flex-warp: nowrap / warp / warp-reverse ( dùng khi co screen lại các item trên 1 hàng có duy chuyển lên/xuống hàng khác hay không)

    @ nowarp : (Seting defual) không xuống dòng

    @ warp : xuống dòng

    @ warp-reverse : lên dòng trên

-9- flex-basic : chỉnh kích thước cho main-size (kích thước của item)

-10- flex-grow : lớn lên

    @ EX :

    ...{
    ...
    animation : grwoth ease-in 0.5s;
    }

    @keyframes growth {
        from{
            opacity : 0; (độ trong suốt)
            height : 50%;
        }
        to{
            opacity : 1;
            height : 100%;
        }
    }

-11- flex-shrink : thu nhỏ lại

-12-order : đánh số thứ tự các item

//--------------------------------------------------------------------//

##
