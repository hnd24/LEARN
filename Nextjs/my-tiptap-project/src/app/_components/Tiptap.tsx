'use client';

import {EditorContent, useEditor} from '@tiptap/react';
import StarterKit from '@tiptap/starter-kit';

const Tiptap = () => {
	const editor = useEditor({
		extensions: [StarterKit],
		content: '<p>Hello World! 🌎️</p>', // Nội dung ban đầu
		// Đảm bảo chỉ render client-side để tránh vấn đề SSR
		immediatelyRender: false,
		onUpdate: ({editor}) => {
			// Log HTML sau mỗi lần cập nhật
			console.log(editor.getHTML());
		},
	});

	return <EditorContent editor={editor} />;
};

export default Tiptap;
