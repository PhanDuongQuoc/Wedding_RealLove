// script.js

// Lấy tất cả các liên kết trong thanh điều hướng
const menuLinks = document.querySelectorAll('.menu li a');

// Lấy iframe
const contentFrame = document.querySelector('iframe[name="contentFrame"]');

// Lặp qua tất cả các liên kết
menuLinks.forEach(link => {
  link.addEventListener('click', function(event) {
    // Ngăn trình duyệt tải lại trang
    event.preventDefault();

    // Lấy giá trị href của liên kết và thay đổi src của iframe
    const pageUrl = this.getAttribute('href');
    if (pageUrl) {
      contentFrame.setAttribute('src', pageUrl);

      // Bỏ active ở tất cả các mục và đặt active cho mục đã chọn
      menuLinks.forEach(link => link.parentElement.classList.remove('active'));
      this.parentElement.classList.add('active');
    }
  });
});