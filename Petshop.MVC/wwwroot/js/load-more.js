document.addEventListener('DOMContentLoaded', function () {

    // Shop Load More
    const loadMore = document.getElementById("loadMore");
    const productContainer = document.getElementById("productContainer");
    let skip = 3;
    const productCount = parseInt(document.getElementById("productCount")?.value);

    loadMore?.addEventListener('click', function () {
        fetch(`/Shop/partial?skip=${skip}`)
            .then(response => response.text())
            .then(html => {
                if (productContainer) productContainer.innerHTML += html;
                skip += 3;

                if (skip >= productCount && loadMore) {
                    loadMore.remove();
                }
            });
    });

    // Blog Load More 
    const blogLoadMore = document.getElementById("blogLoadMore");
    const blogContainer = document.getElementById("blogContainer");
    let blogSkip = 3;
    const blogCount = parseInt(document.getElementById("blogCount")?.value);

    blogLoadMore?.addEventListener('click', function () {
        fetch(`/Blog/Partial?skip=${blogSkip}`)
            .then(response => response.text())
            .then(html => {
                if (blogContainer) blogContainer.innerHTML += html;
                blogSkip += 3;

                if (blogSkip >= blogCount && blogLoadMore) {
                    blogLoadMore.remove();
                }
            });
    });
});
