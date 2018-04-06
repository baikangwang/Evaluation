//------------------分页部分开始-------------------------------

function onPageChange(e) {
    var PerPage = $("#per_page_select").val();
    var CuttentPage = e.attr("data_page");  
    onSearch(PerPage, CuttentPage);
}

function onPerPageChange(e) {
    var PerPage = e.value;
    var CuttentPage = 1;

    onSearch(PerPage, CuttentPage);
}

function selectPerPage() {
    var select = '<div style="margin:auto;width:200px;margin-top: 7px;"><span class="per_page_label">当前页记录条数  : &nbsp; </span>';
    select += '<select class="PerPageSelect" id="per_page_select"  onchange="onPerPageChange(this);" >';
    select += '<option value="5" selected="selected">5</option>';
    select += '<option value="10">10</option>';
    select += '<option value="15">15</option>';
    select += '<option value="20">20</option>';
    select += '<option value="50">50</option>';
    select += '<option value="100">100</option>';
    select += '<option value="200">200</option>';
    select += '<option value="10000">10000</option>';
    select += '</select></div>'; 
    return select;   
}

function buildLink(page, label, linkClass, conditional, conditionalClass) {
    var link = '<a href="#" data_page=' + page + ' class="' + linkClass;
    var li = '<li';
    if (conditional) {
        link += ' ' + conditionalClass;
        li += ' class="' + conditionalClass + '"';
    } else {
        link += '" onclick="onPageChange($(this))';
    }
    link += '">' + label + '</a>';
    li += '>' + link + '</li>';
    return li;
}

function recordsCount(recordCount, currentPage, recordPerPage) {
    var from = (currentPage - 1) * recordPerPage + 1;
    if (from < 0) {
        from = 0;
    }
    var to = currentPage * recordPerPage;
    if (to > recordCount) {
        to = recordCount;
    }
    var span = '<span id="record_count" class="record_count" style="float:left;padding-top: 7px;">总共 ' + recordCount + ' 条记录; 当前显示 : <span class="record_bounds">'
        + from + ' ~ ' + to + '</span> 条 </span>';

    return span;
}

function myPaginationLinks(recordCount, currentPage, pages, pageLinkClass, activePageClass, disabledPageClass) {
    var pageLinks = '<ul id="pagination_links" class="pagination" style="float: right; margin:0;">';
    pageLinks += '<li><span>页数:' + pages + ' </span></li>';
    var page = currentPage - 1;
    if (page <= 0) {
        page = 1;
    }
    pageLinks += buildLink(page, '上一页', 'page_link page_prev', currentPage <= 1, disabledPageClass);

    var skipleft = 0;
    var skipright = 0;
    for (var i = 1; i <= pages; i++) {
        if (i == 1 || i == pages || (i >= currentPage - 2 && i <= currentPage + 2)) {
            var li = buildLink(i, i, pageLinkClass, i == currentPage, activePageClass);
            pageLinks = pageLinks + li;
        } else if (i < currentPage - 2 && skipleft == 0) {
            var li = '<li><span class="page_break">…</span></li>';
            pageLinks = pageLinks + li;
            skipleft = 1;
        } else if (i > currentPage + 2 && skipright == 0) {
            var li = '<li><span class="page_break">…</span></li>';
            pageLinks = pageLinks + li;
            skipright = 1;
        }
    }

    page = currentPage * 1 + 1;
    if (page >= pages) {
        page = pages;
    }
    pageLinks += buildLink(page, '下一页', 'page_link page_next', currentPage >= pages, disabledPageClass);

    pageLinks = pageLinks + '</ul>';

    return pageLinks;
};

//------------------分页部分结束 -------------------------------