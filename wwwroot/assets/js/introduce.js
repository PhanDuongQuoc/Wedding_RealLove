
 // modal contact 

      // Lấy modal
     var modal = document.getElementById("contactModal");

     // Lấy nút để mở modal
     var btn = document.getElementById("openModal");

     // Lấy phần <span> để đóng modal
     var span = document.getElementsByClassName("close")[0];

     // Khi người dùng nhấp vào nút, mở modal
     btn.onclick = function() {
         modal.style.display = "block";
     }

     // Khi người dùng nhấp vào <span> (x), đóng modal
     span.onclick = function() {
         modal.style.display = "none";
     }

     // Khi người dùng nhấp ra ngoài modal, đóng modal
     window.onclick = function(event) {
         if (event.target == modal) {
             modal.style.display = "none";
         }
     }

     // Xử lý gửi form
     document.getElementById("contactForm").onsubmit = function(event) {
         event.preventDefault(); // Ngăn chặn hành động gửi mặc định
         alert("Cảm ơn bạn đã gửi liên hệ !"); // Thay đổi thành hành động thực tế bạn muốn
         modal.style.display = "none"; // Đóng modal sau khi gửi
     }