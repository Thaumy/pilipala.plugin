# pilipala.plugin

噼哩啪啦插件存储库

plugins of pilipala

## 可选插件

这类插件的装载与否不会影响噼哩啪啦的正常工作。

### Llink

替换正文中的`<{}>`标记块。

### Summarizer

为`IPost`提供`Summary`字段（概要），并在必要时从正文生成概要。

### EmailNotifier

使用电子邮件对噼哩啪啦事件予以通知。

### Cacher

为文章和评论加载提供缓存加速。

### Markdown

翻译正文中的Markdown为HTML。

## 默认集成的插件

噼哩啪啦内核为这些插件提供集成支持，始终应该启用这些插件以保证系统功能的完整性。

### PostComments

为`IPost`提供`Comments`字段

### CommentUserName

为`IComment`提供`UserName`字段

### CommentReplies

为`IComment`提供`Replies`字段
