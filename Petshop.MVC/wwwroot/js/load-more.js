const loadMore = document.getElementById("loadMore");
const productContainer = document.getElementById("productContainer");
let skip = 3;
const productCount = parseInt(document.getElementById("productCount").value);

    loadMore.addEventListener('click', function () {
        fetch(`https://localhost:7270/Shop/partial?skip=${skip}`)
            .then(response => response.text())
            .then(html => {
                productContainer.innerHTML += html;
                skip += 3;

                if (skip >= productCount) {
                    loadMore.remove();
                }
            });
    });